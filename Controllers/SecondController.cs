using Microsoft.AspNetCore.Mvc;

namespace MyFirstWebServer.Controllers;

public class SecondController : Controller
{
    [HttpPost]
    public IActionResult Method(string name,string email, string phone, string message)
    {
        return View();
    }
}