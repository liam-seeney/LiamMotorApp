using System.ComponentModel.DataAnnotations;

namespace LiamMotorApp.Common.Models.EnquiryModels;

public class CreateEnquiry
{
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string EmailAddress { get; set; } = string.Empty;
  public string Message { get; set; } = string.Empty; 
}
