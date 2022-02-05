
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace core.Models;
public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> dbContextOptions)
    : base(dbContextOptions)
    { }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Profile> Profiles { get; set; }
}