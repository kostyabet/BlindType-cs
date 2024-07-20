using Microsoft.AspNetCore.Mvc;

namespace BlindType_cs.Controllers.Typing;

public class TypingMainController : Controller
{
    public IActionResult Type()
    {
        return View();
    }
}