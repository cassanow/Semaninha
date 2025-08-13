using Microsoft.AspNetCore.Mvc;
using Semaninha.Interface;
using Semaninha.Models;

namespace Semaninha.Controllers;

public class AlbumController : Controller
{
    
    private readonly IAlbumService _albumService;

    public AlbumController(IAlbumService albumService)
    {
        _albumService = albumService;   
    }
    
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(string nomeAlbum)
    {
        var album = await _albumService.GetAlbum(nomeAlbum);

        return View(album);
        
    }
}