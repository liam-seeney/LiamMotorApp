using LiamMotorApp.Common.Models.EnquiryModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LiamMotorApp.Website.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
  private readonly ILogger<IndexModel> _logger = logger;

  [BindProperty]
  public CreateEnquiry? Data {  get; set; }

  public void OnGet()
  {

  }

  public async Task<IActionResult> OnPostAsync()
  {
    if(!ModelState.IsValid)
    {
      return Page();
    }

    if (Data != null)
    {

    }
  }
}
