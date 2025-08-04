using Newtonsoft.Json;

namespace SRP.WebUI.Dtos.RapidApi;

public class RootTastyApiDto
{
    [JsonProperty("results")]
    public ICollection<ResultTastyApiDto>? ResultTastyApiDtos { get; set; }
}
public class ResultTastyApiDto
{
    [JsonProperty("name")]
    public string? Name { get; set; }
    [JsonProperty("original_video_url")]
    public string? VideoUrl { get; set; }
    [JsonProperty("total_time_minutes")]
    public int? TotalTimeMinutes { get; set; }
    [JsonProperty("thumbnail_url")]
    public string? ThumbnailUrl { get; set; }
}