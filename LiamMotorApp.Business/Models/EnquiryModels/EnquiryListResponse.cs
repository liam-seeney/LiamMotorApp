using LiamMotorApp.Business.Entities;

namespace LiamMotorApp.Business.Models.EnquiryModels;

public class EnquiryListResponse
{
  public Guid Id { get; set; }
  public string FirstName { get; set; } = string.Empty;
  public string LastName { get; set; } = string.Empty;
  public string EmailAddress { get; set; } = string.Empty;
  public string Message {  get; set; } = string.Empty;

  public EnquiryListResponse() { }

  public EnquiryListResponse(Enquiry enquiry)
  {
    Id = enquiry.Id;
    FirstName = enquiry.FirstName;
    LastName = enquiry.LastName;
    EmailAddress = enquiry.EmailAddress;
    Message = enquiry.Message;
  }
}
