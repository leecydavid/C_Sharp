// Worked with Kirstie, Stephen, Minh
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller 
{
    [HttpGet("/")]
    public ViewResult Index()
    {
        return View("Index");
    }

    [HttpGet("/result")]
    public IActionResult Result()
    {
        return View("Result");
    }

    [HttpPost("/addStudent")]
    public IActionResult AddStudent(string Name, string Location, string Language, string Comment)
    {
        TempData["Name"] = Name;
        TempData["Location"] = Location;
        TempData["Language"] = Language;
        TempData["Comment"] = Comment;

        Console.WriteLine($"{Name}, {Location}, {Language}, {Comment}");
        return Redirect("/result");
    }
}