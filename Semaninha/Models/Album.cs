using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class Album
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("artist")] 
    public Artist Artist { get; set; }

    [JsonPropertyName("playcount")] 
    public string Playcount { get; set; }

    [JsonPropertyName("url")] 
    public string Url { get; set; }
}