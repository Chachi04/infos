using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ex1.Models;

namespace ex1.Controllers;

public class GalleryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ViewGallery()
    {
        return View();
    }

    public IActionResult AddImage()
    {
        return View();
    }
    public IActionResult RemoveImage()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
