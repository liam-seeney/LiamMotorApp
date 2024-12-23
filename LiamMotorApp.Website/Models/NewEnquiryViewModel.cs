using LiamMotorApp.Common.Models.EnquiryModels;

namespace LiamMotorApp.Website.Models;

public class NewEnquiryViewModel
{
  public NewEnquiryViewModel()
  {
    Model = new();
  }

  public CreateEnquiry Model { get; set; }
}
