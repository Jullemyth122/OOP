using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _.Models;

namespace _.Controllers;

public class Dashboard : Controller
{
    private readonly ILogger<Dashboard> _logger;

    public Dashboard(ILogger<Dashboard> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Orders()
    {
        return View("~/Views/Dashboard/Orders.cshtml");
    }
    public IActionResult Accounting()
    {
        return View("~/Views/Dashboard/Accounting.cshtml");
    }
    public IActionResult Inventory()
    {
        return View("~/Views/Dashboard/Inventory.cshtml");
    }
    public IActionResult Reports()
    {
        return View("~/Views/Dashboard/Reports.cshtml");
    }
    public IActionResult Settings()
    {
        return View("~/Views/Dashboard/Settings.cshtml");
    }
    // public IActionResult Auth()
    // {
    //     return View("~/Views/Authentication/Auth.cshtml");
    // }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
