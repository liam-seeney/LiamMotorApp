namespace LiamMotorApp.Business.Entities;

public class Enquiry : BaseEntity
{
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string EmailAddress { get; set; } = string.Empty;
  public string Message { get; set; } = string.Empty;
}
