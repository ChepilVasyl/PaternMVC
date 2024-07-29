using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFirstWebServer.Models.PersonalDataModel;

namespace MyFirstWebServer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<PersonalDataModel>? MyModel { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}