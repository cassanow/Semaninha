using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class Image
{
    
    [JsonPropertyName("size")] 
    public string Size { get; set; }

    [JsonPropertyName("#text")] 
    public string Url { get; set; }
}