using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
            new Category{Id=1, Name="Bluzki i koszule", DisplayOrder=1},
            new Category { Id= 2, Name= "Marynarki", DisplayOrder= 2},
            new Category { Id = 3, Name="Spodnie", DisplayOrder = 3},
            new Category { Id = 4, Name = "Spódnice", DisplayOrder = 4}
            );
        }
    }
}
