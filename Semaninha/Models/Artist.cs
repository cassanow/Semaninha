using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class Artist
{
    [JsonPropertyName("name")] 
    public string Name { get; set; }

    [JsonPropertyName("url")] 
    public string Url { get; set; }
}