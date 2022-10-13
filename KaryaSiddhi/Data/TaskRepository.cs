using Microsoft.EntityFrameworkCore;
using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Data
{
    public class TaskRepository
    {
        private readonly KaryaSiddhiDbContext karyaSiddhiDbContext;

        public TaskRepository()
        {
            var connectionstring = "server=MRIPF2RCVFG;database=KaryaSiddhiDb;Trusted_Connection=true";
            var optionsBuilder = new DbContextOptionsBuilder<KaryaSiddhiDbContext>();
            optionsBuilder.UseSqlServer(connectionstring);
            karyaSiddhiDbContext = new KaryaSiddhiDbContext(optionsBuilder.Options);
        }

        public async Task<List<Task>> GetAllTasks() =>  await karyaSiddhiDbContext.Tasks.ToListAsync();

        public async Task<Task?> getTask(Guid id) => await karyaSiddhiDbContext.Tasks.FirstOrDefaultAsync(t => t.Id == id);

        public async Task<Task> AddTask(Task task)
        {
            await karyaSiddhiDbContext.Tasks.AddAsync(task);
            await karyaSiddhiDbContext.SaveChangesAsync();
            return task;
        }

       


    }
}
