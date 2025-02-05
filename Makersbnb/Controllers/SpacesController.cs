using Microsoft.AspNetCore.Mvc;
using Makersbnb.Models;

namespace Makersbnb.Controllers;

public class SpacesController : Controller
{
    private readonly ILogger<SpacesController> _logger;

    public SpacesController(ILogger<SpacesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index() // Handling `Get "/Spaces"`
    {
        ViewBag.Space1 = new Space("Cozy Apartment", "A place near London Waterloo", 100, 3, "No smoking and pets allowed.");
        
        return View();
    }

    public IActionResult New()
    {
        return View();
    }

    [Route("/Spaces")]
    [HttpPost]
    public IActionResult Create(Space space)
    {
        MakersbnbDbContext dbContext = new MakersbnbDbContext();
        dbContext.Spaces.Add(space);
        dbContext.SaveChanges();

        return new RedirectResult("/Spaces");
    }
}