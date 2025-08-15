using System.Text.Json;
using Semaninha.Interface;
using Semaninha.Models;

namespace Semaninha.Service;

public class AlbumService : IAlbumService
{
    private readonly HttpClient _client;

    public AlbumService(HttpClient client)
    {
        _client = client;
    }

    public async Task<List<Album>> GetAlbum(string nomeAlbum)
    {
        var key = "1766bd528b32b4e1ab0dc6324067fd8a";
        var url =
            $"https://ws.audioscrobbler.com/2.0/?method=album.search&album={nomeAlbum}&api_key={key}&format=json&limit=5";

        var response = await _client.GetAsync(url);

        var json = await response.Content.ReadAsStringAsync();

        using var doc = JsonDocument.Parse(json);

        var albumJson = doc.RootElement.GetProperty("results")
            .GetProperty("albummatches")
            .GetProperty("album");

        var lista = albumJson.EnumerateArray()
            .Select(a => new Album
            {
                Name = a.GetProperty("name").GetString(),
                Url = a.GetProperty("url").GetString()
            }).ToList();

        return lista;
    }
}