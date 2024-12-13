using LiamMotorApp.Business.Models.EnquiryModels;
using LiamMotorApp.Common.Models.EnquiryModels;

namespace LiamMotorApp.Business.Services.Interfaces;

public interface IEnquiryService
{
  Task CreateEnquiry(CreateEnquiry createEnquiry);
  Task<IEnumerable<EnquiryListResponse>> GetEnquiriesAsync();
  Task<EnquiryResponse?> GetEnquiryByIdAsync(Guid id);
  Task DeleteEnquiryAsync(Guid id);
}
