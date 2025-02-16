using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rabi_Shah_Dot_Net_project.Models;

namespace Rabi_Shah_Dot_Net_project.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Rabi_Shah_Dot_Net_project.Models.Volunteer> Volunteer { get; set; } = default!;
    }
}
