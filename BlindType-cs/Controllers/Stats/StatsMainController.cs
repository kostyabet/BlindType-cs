using Microsoft.AspNetCore.Mvc;

namespace BlindType_cs.Controllers.Stats;

public class StatsMainController : Controller
{
    public IActionResult Stats()
    {
        return View();
    }
}