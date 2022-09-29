using Entities.Models;
using Microsoft.EntityFrameworkCore;
#nullable disable
namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> option) :
        base(option)
        {
        }

        public DbSet<User_Details> User_Details { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Assert> Assert { get; set; }
        public DbSet<RefSet> RefSet { get; set; }
        public DbSet<RefTerm> RefTerm { get; set; }
        public DbSet<SetRefTerm> SetRefTerm { get; set; }
    }
}
