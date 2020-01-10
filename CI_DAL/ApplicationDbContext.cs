using CI_DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CI_DAL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    { }

    public DbSet<Item> Items { get; set; }
    }
}