using System.Text.Json.Serialization;

namespace Semaninha.Models;

public class TopTracksResponse
{
    [JsonPropertyName("toptracks")]
    public TopTracks TopTracks { get; set; }
}