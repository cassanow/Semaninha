using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class Album
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("artist")]
    public string Artist { get; set; }
    
    [JsonPropertyName("url")]
    public string URL { get; set; }
}