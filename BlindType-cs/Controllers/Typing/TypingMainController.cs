using Microsoft.AspNetCore.Mvc;
using BlindType_cs.Models;

namespace BlindType_cs.Controllers.Typing;

public class TypingMainController : Controller
{
    private readonly TypingTextModel _texts = new();
    public IActionResult Type()
    {
        var text = _texts.GetTypingText().ToLower();
        return View((object)text);
    }
}