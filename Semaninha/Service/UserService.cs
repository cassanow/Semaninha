using System.Text.Json;
using Semaninha.Interface;
using Semaninha.Models;

namespace Semaninha.Service;

public class UserService : IUserService
{
    private readonly HttpClient _httpClient;

    public UserService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Track>> GetUserTopTracks(string username, string period)
    {
        var key = "1766bd528b32b4e1ab0dc6324067fd8a";
        var url =
            $"https://ws.audioscrobbler.com/2.0/?method=user.gettoptracks&user={username}&api_key={key}&format=json&period={period}";

        var response = await _httpClient.GetAsync(url);

        var json = await response.Content.ReadAsStringAsync();
        var resultado = JsonSerializer.Deserialize<TopTracksResponse>(json);

        return resultado.TopTracks.Tracks;
    }

    public async Task<List<Album>> GetUserTopAlbums(string username, string period)
    {
        var key = "1766bd528b32b4e1ab0dc6324067fd8a";
        var url =
            $"https://ws.audioscrobbler.com/2.0/?method=user.gettopalbums&user={username}&api_key={key}&format=json&period={period}";
        
        var response = await _httpClient.GetAsync(url);
        
        var json = await response.Content.ReadAsStringAsync();
        
        var resultado = JsonSerializer.Deserialize<TopAlbunsResponse>(json);

        return resultado.Albuns.Albuns;
    }
}