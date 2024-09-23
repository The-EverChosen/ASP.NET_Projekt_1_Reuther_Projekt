using ASP.NET_Projekt_1_Reuther_Projekt.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Projekt_1_Reuther_Projekt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<JopPost> jobPostings { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
