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

        public async Task<Task> getTask(Guid id) => await karyaSiddhiDbContext.Tasks.FindAsync(id);

        public async Task<Task> AddTask(Task task)
        {
            await karyaSiddhiDbContext.Tasks.AddAsync(task);
            await karyaSiddhiDbContext.SaveChangesAsync();
            return task;
        }

        public async Task<Task> UpdateTask(Guid id, Task task)
        {
            var oldTask = await karyaSiddhiDbContext.Tasks.FindAsync(id);
            oldTask.Title = task.Title;
            oldTask.Description = task.Description;
            oldTask.DueDate = task.DueDate;
            oldTask.Priority = task.Priority;
            oldTask.IsComplete = task.IsComplete;
            await karyaSiddhiDbContext.SaveChangesAsync();
            return task;
        }

        public async Task<Task> DeleteTask(Guid id)
        {
            var task = await karyaSiddhiDbContext.Tasks.FindAsync(id);  
            var removedTask = karyaSiddhiDbContext.Tasks.Remove(task);
            await karyaSiddhiDbContext.SaveChangesAsync();
            return task;
        }




    }
}
