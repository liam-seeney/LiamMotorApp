using System.ComponentModel.DataAnnotations;

namespace LiamMotorApp.Common.Models.EnquiryModels;

public class CreateEnquiry
{
  [Required]
  public required string FirstName { get; set; }

  [Required] 
  public required string LastName { get; set; }

  [Required]
  public required string EmailAddress { get; set; }

  [Required]
  public required string Message { get; set; }
}
