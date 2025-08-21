using Microsoft.EntityFrameworkCore;
using SnusRanking.Models;

namespace SnusRanking.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Snus> Snus { get; set; }
    }
}
