using LiamMotorApp.Business.Models.EnquiryModels;
using LiamMotorApp.Business.Services.Interfaces;
using LiamMotorApp.Common.Models.EnquiryModels;
using Microsoft.AspNetCore.Mvc;

namespace LiamMotorApp.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EnquiryController(IEnquiryService enquiryService) : ControllerBase
{
  private readonly IEnquiryService _enquiryService = enquiryService;

  [HttpGet]
  [ProducesResponseType(typeof(IEnumerable<EnquiryListResponse>), 200)]
  public async Task<IActionResult> GetAllEnquiries()
  {
    return Ok(await _enquiryService.GetEnquiriesAsync());
  }

  [HttpGet("{id}")]
  [ProducesResponseType(typeof(EnquiryResponse), 200)]
  public async Task<IActionResult> GetEnquiryById(Guid id)
  {
    return Ok(await _enquiryService.GetEnquiryByIdAsync(id));
  }

  [HttpPost]
  [ProducesResponseType(201)]
  public async Task<IActionResult> CreateEnquiry(CreateEnquiry data)
  {
    await _enquiryService.CreateEnquiry(data);
    return Ok(data);
  }

  [HttpDelete]
  [ProducesResponseType(204)]
  public async Task<IActionResult> DeleteEnquiry(Guid id)
  {
    await _enquiryService.DeleteEnquiryAsync(id);
    return NoContent();
  }
}
