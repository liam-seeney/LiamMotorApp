using LiamMotorApp.Business.Entities;
using LiamMotorApp.Business.Repositories.Interfaces;

namespace LiamMotorApp.Business.Repositories;

public class EnquiryRepository(DatabaseContext context)
  : RepositoryBase<Enquiry>(context), IEnquiryRepository
{

}
