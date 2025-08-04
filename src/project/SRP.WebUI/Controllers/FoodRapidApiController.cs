using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SRP.WebUI.Dtos.RapidApi;

namespace SRP.WebUI.Controllers
{
    public class FoodRapidApiController(IConfiguration configuration) : Controller
    {
        public async Task<ActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(configuration["TastyRapidApi:Url"]!),
                Headers =
                {
                    { "x-rapidapi-key", configuration["TastyRapidApi:Key"]! },
                    { "x-rapidapi-host", configuration["TastyRapidApi:Host"]! },
                },
            };
            using var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            var root = JsonConvert.DeserializeObject<RootTastyApiDto>(body);
            var values = root?.ResultTastyApiDtos;
            return View(values!.ToList());
        }
    }
}