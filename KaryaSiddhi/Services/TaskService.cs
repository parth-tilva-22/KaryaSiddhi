using KaryaSiddhi.Data;
using Task = KaryaSiddhi.Models.Task;


namespace KaryaSiddhi.Services
{
    public class TaskService
    {
        private readonly TaskRepository taskRepository;

        public TaskService(TaskRepository taskRepository) 
        {
            this.taskRepository = taskRepository;
        }


        public async Task<List<Task>> GetAllTasks() => await taskRepository.GetAllTasks();
        
        public async Task<Task> AddTask(Task task)
        {
            task.Id = Guid.NewGuid();
            var responseTask = await taskRepository.AddTask(task);
            return task;
        }
    }
}
