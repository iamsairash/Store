using BookStore.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, DisplayOrder = 1, Name = "Sci Fi" },
                new Category { Id = 2, DisplayOrder = 2, Name = "Self Help" },
                new Category { Id = 3, DisplayOrder = 3, Name = "Education" }
                );
        }
    }
}
