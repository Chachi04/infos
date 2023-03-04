using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using View.Models;

namespace View.Controllers;

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

    public IActionResult Page1()
    {
        ViewBag.address = "Ruse 7000";
        ViewBag.country = "Bulgaria";

        ViewData["phone"] = "+359 123 456 789";

        return View();
    }

    public IActionResult Page2()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
