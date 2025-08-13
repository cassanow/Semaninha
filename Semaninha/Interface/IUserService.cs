using Semaninha.Models;

namespace Semaninha.Interface;

public interface IUserService
{
    Task<List<Track>> GetUserTopTracks(string username);    
}