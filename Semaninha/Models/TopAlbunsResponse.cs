using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class TopAlbunsResponse
{
    [JsonPropertyName("topalbums")] 
    public TopAlbuns Albuns { get; set; }
}