using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { CategoryId = 2, Name = "Sci-fi", DisplayOrder = 2 },
                    new Category { CategoryId = 3, Name = "History", DisplayOrder = 3 }
                );


            //base.OnModelCreating(modelBuilder);
        }
    }
}
