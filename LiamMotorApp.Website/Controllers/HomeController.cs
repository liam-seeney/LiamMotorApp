using LiamMotorApp.Common.Models.EnquiryModels;
using LiamMotorApp.Common.Services.Interfaces;
using LiamMotorApp.Website.Models;

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LiamMotorApp.Website.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IApiIntegrationService _apiIntegration;

    public HomeController(ILogger<HomeController> logger, IApiIntegrationService apiIntegration)
    {
      _logger = logger;
      _apiIntegration = apiIntegration;
    }

    public IActionResult Index()
    {
      NewEnquiryViewModel model = new();
      return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> CreateEnquiry(NewEnquiryViewModel enquiry)
    {
      await _apiIntegration.PostAsync(Globals.POSTENQUIRY, enquiry.Model);
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
