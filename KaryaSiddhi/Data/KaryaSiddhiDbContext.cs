using Microsoft.EntityFrameworkCore;
using KaryaSiddhi.Models;
using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Data
{
    public class KaryaSiddhiDbContext : DbContext
    {


        public KaryaSiddhiDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
    }
}
