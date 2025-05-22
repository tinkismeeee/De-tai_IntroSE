using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DO_AN.Models;

namespace DO_AN.Controllers;

public class HomeController : Controller
{
    public readonly ILogger<HomeController> _logger;

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
    public IActionResult Sell_Equipment()
    {
        return View();
    }
    public IActionResult Cart()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult PayProduct()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

