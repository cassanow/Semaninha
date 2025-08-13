using System.Text.Json;
using Semaninha.Models;

class Program
{
    static async Task Main(string[] args)
    {
        var username = "artuzie"; 
        var apiKey = "1766bd528b32b4e1ab0dc6324067fd8a"; 

        var httpClient = new HttpClient();
        var url = $"https://ws.audioscrobbler.com/2.0/?method=user.gettoptracks&user={username}&api_key={apiKey}&format=json";

        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        Console.WriteLine("JSON retornado");

        var resultado = JsonSerializer.Deserialize<TopTracksResponse>(json);

        if (resultado?.TopTracks?.Tracks != null)
        {
            Console.WriteLine("\nTop Tracks:");
            foreach (var t in resultado.TopTracks.Tracks)
            {
                Console.WriteLine($"{t.Name} - {t.Artist?.Name} (Playcount: {t.Playcount})");
            }
        }
        else
        {
            Console.WriteLine("Nenhuma track encontrada.");
        }
    }
}