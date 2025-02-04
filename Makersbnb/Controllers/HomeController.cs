using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Makersbnb.Models;

namespace Makersbnb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult Team()
    {
        return View();
    }

    public IActionResult Contactus()
    {
        ViewBag.Email = new string[]
        {
            "fake1@email.com",
            "fake2@email.com",
            "fake3@email.com"
        };
        return View();
    }
}
