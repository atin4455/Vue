using Microsoft.EntityFrameworkCore;

namespace Vue.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Guestbook> Guestbooks { get; set; }
    }
}