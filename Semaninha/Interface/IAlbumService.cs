using Semaninha.Models;

namespace Semaninha.Interface;

public interface IAlbumService
{
    Task<List<Album>> GetAlbum(string nomeAlbum);
}