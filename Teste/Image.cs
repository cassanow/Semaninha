using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class Image
{
    public string Size { get; set; }
    
    [JsonPropertyName("#text")]
    public string Text { get; set; }
}