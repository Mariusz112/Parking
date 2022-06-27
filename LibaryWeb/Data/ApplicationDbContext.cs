using LibaryWeb.Model;
using Microsoft.EntityFrameworkCore;

namespace LibaryWeb.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Category { get; set; }
    public DbSet<Author> Author { get; set; }
}
