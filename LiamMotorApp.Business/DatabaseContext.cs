using LiamMotorApp.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiamMotorApp.Business;

public class DatabaseContext : DbContext
{
  public DatabaseContext(DbContextOptions<DatabaseContext> context) : base(context) { }

  public DbSet<Enquiry> Enquiries { get; set; }
}
