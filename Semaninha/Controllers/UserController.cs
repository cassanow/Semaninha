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
    public async Task<IActionResult> GetTopTracks(string nomeUsuario)
    {
        var topTracks = await _userService.GetUserTopTracks(nomeUsuario);
       
        return View(topTracks);
    }
}