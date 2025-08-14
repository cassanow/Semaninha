using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class TopAlbuns
{
    [JsonPropertyName("album")]
    public List<Album> Albuns { get; set; }
}