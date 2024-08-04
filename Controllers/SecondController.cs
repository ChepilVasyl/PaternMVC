using Microsoft.AspNetCore.Mvc;
using MyFirstWebServer.Data;
using MyFirstWebServer.Models.PersonalDataModel;
using SQLitePCL;

namespace MyFirstWebServer.Controllers;

public class SecondController : Controller
{
    private ApplicationDbContext? _myContext;
    public SecondController(ApplicationDbContext myContext)
    {
        Console.WriteLine("Зайшло в конструктор");
        Console.WriteLine(myContext);
        _myContext = myContext;
    }
    /*public IActionResult Method(string name,string email, string phone, string message)
    {
        return View();
    }*/
    [HttpGet]
    public IActionResult Method()
    {
        return View();
    }
    public IActionResult SomeName()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Method(PersonalDataModel pdm)
    {
        Console.WriteLine("Логування 2");
        if (ModelState.IsValid)
        {
            Console.WriteLine("Зайшло і перевірило валідацію");
            _myContext.MyModel.Add(pdm);
            await _myContext.SaveChangesAsync();
            return RedirectToAction(nameof(SomeName));
        }

        return View(pdm);
    }
}