using Microsoft.AspNetCore.Mvc;
using CuatroEnLinea.Data;
using CuatroEnLinea.Models;

public class GameController : Controller
{
    private readonly ApplicationDbContext _context;

    public GameController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Play()
    {
        return View();
    }

    public IActionResult History()
    {
        var games = _context.Games.ToList();
        return View(games);
    }
}
