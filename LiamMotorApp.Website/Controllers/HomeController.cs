using LiamMotorApp.Website.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiamMotorApp.Website.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
      _logger = logger;
    }

    public IActionResult Index()
    {
      NewEnquiryViewModel model = new NewEnquiryViewModel();
      return View(model);
    }

    public IActionResult CreateEnquiry()
    {
      return RedirectToAction(nameof(Index));
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
  }
}
