using Semaninha.Models;

namespace Semaninha.Interface;

public interface IUserService
{
    Task<List<Track>> GetUserTopTracks(string username, string period);

    Task<List<Album>> GetUserTopAlbums(string username, string period, int limit);
}