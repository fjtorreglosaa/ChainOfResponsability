using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResponsability.Infrastructure.Contexts.Identity
{
    public class ApplicationIdentityDbContext : IdentityDbContext<User>
    {
        public ApplicationIdentityDbContext() { }
        public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"
                    Server=localhost;
                    Database=ChainOfResponsabilityIdentityDB;
                    User Id=sa;
                    Password=Password1*;
                    MultipleActiveResultSets=true;
                    trustServerCertificate=true
                ");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
