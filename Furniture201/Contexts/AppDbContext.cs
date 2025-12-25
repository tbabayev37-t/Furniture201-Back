using Furniture201.Models;
using Microsoft.EntityFrameworkCore;

namespace Furniture201.Contexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Blog> Blogs { get; set; }
    }
}
