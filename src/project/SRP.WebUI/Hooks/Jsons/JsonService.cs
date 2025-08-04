using System.Net;
using Newtonsoft.Json;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using SRP.WebUI.Dtos.Validation;

namespace SRP.WebUI.Hooks.Jsons;

public class JsonService(IHttpClientFactory factory, IHttpContextAccessor httpContextAccessor)
{
    private readonly HttpClient _client = factory.CreateClient();

    private void AddJwtTokenHeader()
    {
        var accessToken = httpContextAccessor.HttpContext?.Request?.Cookies["access_token"];
        if (!string.IsNullOrWhiteSpace(accessToken))
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }
    }

    public async Task<ICollection<T>?> GetAllAsync<T>(string url)
    {
        AddJwtTokenHeader();
        var response = await _client.GetAsync(url);
        if (!response.IsSuccessStatusCode) return null;
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ICollection<T>>(content);
    }

    public async Task<T?> GetAsync<T>(string url)
    {
        AddJwtTokenHeader();
        var response = await _client.GetAsync(url);
        if (!response.IsSuccessStatusCode) return default;
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(content);
    }

    public async Task FireAndForgetPutAsync<TRequest>(string url, TRequest data)
    {
        AddJwtTokenHeader();
        var jsonData = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        await _client.PutAsync(url, content);
    }

    public async Task<ICollection<T>?> GetAsyncWithQuery<T>(string baseUrl,
        Dictionary<string, IEnumerable<string>> queryParams)
    {
        AddJwtTokenHeader();
        var query = string.Join("&", queryParams
            .SelectMany(kvp => kvp.Value.Select(value => $"{kvp.Key}={Uri.EscapeDataString(value)}")));

        var urlWithQuery = $"{baseUrl}?{query}";
        var response = await _client.GetAsync(urlWithQuery);
        if (!response.IsSuccessStatusCode) return null;

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ICollection<T>>(content);
    }

    //ModelState => FluentValidation Response
    public async Task<bool> PostAsync<TRequest>(string url, TRequest data, ModelStateDictionary modelState)
    {
        AddJwtTokenHeader();
        var jsonData = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await _client.PostAsync(url, content);

        if (response.IsSuccessStatusCode)
            return true;

        if (response.StatusCode == HttpStatusCode.BadRequest)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            var validationErrors = JsonConvert.DeserializeObject<FluentValidationErrorResponse>(errorContent);

            if (validationErrors?.Errors == null) return false;
            foreach (var error in validationErrors.Errors)
            {
                foreach (var msg in error.Errors!)
                {
                    modelState.AddModelError(error.Property!, msg);
                }
            }

            return false;
        }

        throw new Exception($"API error: {response.StatusCode}");
    }

    public async Task DeleteAsync(string url, int id)
    {
        AddJwtTokenHeader();
        var response = await _client.DeleteAsync($"{url}?id={id}");
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Deletion Failed: {response.StatusCode} - {errorContent}");
        }
    }

    public async Task<T?> GetByIdAsync<T>(string urlWithId)
    {
        AddJwtTokenHeader();
        var response = await _client.GetAsync(urlWithId);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Data extraction error: {response.StatusCode} - {errorContent}");
        }

        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(content);
    }

    public async Task UpdateAsync<T>(string url, T data)
    {
        AddJwtTokenHeader();
        var jsonData = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = await _client.PutAsync(url, content);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Update failed: {response.StatusCode} - {errorContent}");
        }
    }

    public async Task<List<SelectListItem>> GetSelectListAsync<T>(string url, Func<T, string?> textSelector,
        Func<T, string?> valueSelector)
    {
        var data = await GetAllAsync<T>(url);
        if (data == null) return [];
        return data.Select(item => new SelectListItem { Text = textSelector(item), Value = valueSelector(item) })
            .ToList();
    }
}