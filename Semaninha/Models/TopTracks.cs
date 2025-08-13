using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class TopTracks
{
    [JsonPropertyName("track")]
    public List<Track> Tracks { get; set; } 
}