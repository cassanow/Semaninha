using Microsoft.AspNetCore.Mvc;
using Semaninha.Interface;
using Semaninha.Models;

namespace Semaninha.Controllers;

public class UserController : Controller
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public IActionResult GetTopTracks()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetTopTracks(string nomeUsuario, string period)
    {
        var topTracks = await _userService.GetUserTopTracks(nomeUsuario, period);
       
        return View(topTracks);
    }

    [HttpGet]
    public IActionResult GetTopAlbums()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> GetTopAlbums(string nomeUsuario, string period)
    {
        var topAlbums = await _userService.GetUserTopAlbums(nomeUsuario, period);
        
        return View(topAlbums);
    }
}