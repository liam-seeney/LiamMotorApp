using LiamMotorApp.Business.Entities;
using LiamMotorApp.Business.Models.EnquiryModels;
using LiamMotorApp.Business.Repositories.Interfaces;
using LiamMotorApp.Business.Services.Interfaces;
using LiamMotorApp.Common.Models.EnquiryModels;

namespace LiamMotorApp.Business.Services;

public class EnquiryService(IEnquiryRepository enquiryRepository) : IEnquiryService
{
  private readonly IEnquiryRepository _enquiryRepository = enquiryRepository;

  public async Task CreateEnquiry(CreateEnquiry createEnquiry)
  {
    Enquiry enquiry = new(createEnquiry);
    _enquiryRepository.AddAsync(enquiry);
    await _enquiryRepository.SaveChangesAsync();
  }

  public async Task DeleteEnquiryAsync(Guid id)
  {
    Enquiry? enquiryToDelete = await _enquiryRepository.GetByIdAsync(id);

    if (enquiryToDelete != null)
    {
      _enquiryRepository.DeleteAsync(enquiryToDelete);
    }

    await _enquiryRepository.SaveChangesAsync();
  }

  public async Task<IEnumerable<EnquiryListResponse>> GetEnquiriesAsync()
  {
    IEnumerable<Enquiry> response = await _enquiryRepository.GetAllAsync();

    return response.Select(e => new EnquiryListResponse(e));
  }

  public async Task<EnquiryResponse?> GetEnquiryByIdAsync(Guid id)
  {
    EnquiryResponse response = new();
    Enquiry? enquiry = await _enquiryRepository.GetByIdAsync(id);

    if (enquiry != null)
    {
      response.Id = enquiry.Id;
      response.FirstName = enquiry.FirstName;
      response.LastName = enquiry.LastName;
      response.EmailAddress = enquiry.EmailAddress;
      response.Message = enquiry.Message;
    }

    return response;
  }
}
