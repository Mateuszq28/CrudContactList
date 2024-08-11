using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CrudContactList.Models;

namespace CrudContactList.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CrudContactList.Models.Contact> Contact { get; set; } = default!;
        public DbSet<CrudContactList.Models.Category> Category { get; set; } = default!;
    }
}
