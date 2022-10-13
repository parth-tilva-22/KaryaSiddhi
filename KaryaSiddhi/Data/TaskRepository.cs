using Microsoft.EntityFrameworkCore;
using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Data
{
    public class TaskRepository
    {
        private readonly KaryaSiddhiDbContext karyaSiddhiDbContext;

        public TaskRepository(KaryaSiddhiDbContext karyaSiddhiDbContext)
        {
            this.karyaSiddhiDbContext = karyaSiddhiDbContext;
        }

        public async Task<List<Task>> GetAllTasks() =>  await karyaSiddhiDbContext.Tasks.ToListAsync(); 

        public async Task<Task> AddTask(Task task)
        {
            await karyaSiddhiDbContext.Tasks.AddAsync(task);
            await karyaSiddhiDbContext.SaveChangesAsync();
            return task;
        }


    }
}
