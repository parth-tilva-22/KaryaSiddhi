using KaryaSiddhi.Data;
using Task = KaryaSiddhi.Models.Task;


namespace KaryaSiddhi.Services
{
    public class TaskService
    {

        
        private readonly TaskRepository taskRepository = new TaskRepository();
       
        public TaskService() 
        {
            
        }


        public async Task<List<Task>> GetAllTasks() => await taskRepository.GetAllTasks();

        public async Task<Task> getTask(Guid id) => await taskRepository.getTask(id);


        public async Task<Task> UpdateTask( Guid id, Task task) => await taskRepository.UpdateTask(id, task);

        public async Task<Task> DeleteTask(Guid id) => await taskRepository.DeleteTask(id);


        public async Task<Task> AddTask(Task task)
        {
            task.Id = Guid.NewGuid();
            return await taskRepository.AddTask(task);
        }

    }
}
