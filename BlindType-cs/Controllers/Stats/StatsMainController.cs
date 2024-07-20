using Microsoft.AspNetCore.Mvc;

namespace BlindType_cs.Controllers.Stats;

public class StatsMainController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}