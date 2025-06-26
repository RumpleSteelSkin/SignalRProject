using Newtonsoft.Json;
using System.Text;

namespace SRP.WebUI.Hooks.Jsons;

public class JsonService(IHttpClientFactory factory)
{
    private readonly HttpClient _client = factory.CreateClient();
    public async Task<ICollection<T>?> GetAsync<T>(string url)
    {
        var response = await _client.GetAsync(url);
        if (!response.IsSuccessStatusCode) return null;
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<ICollection<T>>(content);
    }
    public async Task PostAsync<TRequest>(string url, TRequest data)
    {
        var jsonData = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
        var response = await _client.PostAsync(url, content);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"API hatası: {response.StatusCode} - {errorContent}");
        }
    }
    
    public async Task DeleteAsync(string url, int id)
    {
        var response = await _client.DeleteAsync($"{url}?id={id}");

        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Silme işlemi başarısız: {response.StatusCode} - {errorContent}");
        }
    }
    
    public async Task<T?> GetByIdAsync<T>(string urlWithId)
    {
        var response = await _client.GetAsync(urlWithId);
        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Veri çekme hatası: {response.StatusCode} - {errorContent}");
        }
        var content = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<T>(content);
    }

    
    public async Task UpdateAsync<T>(string url, T data)
    {
        var jsonData = JsonConvert.SerializeObject(data);
        var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

        var response = await _client.PutAsync(url, content);

        if (!response.IsSuccessStatusCode)
        {
            var errorContent = await response.Content.ReadAsStringAsync();
            throw new Exception($"Güncelleme başarısız: {response.StatusCode} - {errorContent}");
        }
    }
    
    


}