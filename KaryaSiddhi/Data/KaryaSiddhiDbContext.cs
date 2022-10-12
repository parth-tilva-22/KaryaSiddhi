using Microsoft.EntityFrameworkCore;
using KaryaSiddhi.Models;


namespace KaryaSiddhi.Data
{
    public class KaryaSiddhiDbContext : DbContext
    {
        public KaryaSiddhiDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Task> Tasks { get; set; }
    }
}
