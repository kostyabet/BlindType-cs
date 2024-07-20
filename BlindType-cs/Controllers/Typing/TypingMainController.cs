using Microsoft.AspNetCore.Mvc;

namespace BlindType_cs.Controllers.Game;

public class MainGameController : Controller
{
    // GET
    public IActionResult Game()
    {
        return View();
    }
}