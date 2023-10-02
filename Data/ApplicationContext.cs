using Lab1.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
