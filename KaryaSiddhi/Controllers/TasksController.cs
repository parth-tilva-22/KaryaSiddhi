using KaryaSiddhi.Data;
using KaryaSiddhi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TasksController : ControllerBase
    {
        private readonly TaskService taskService = new TaskService();   

        public TasksController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks() => Ok(await taskService.GetAllTasks());

        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] Task task) => Ok(await taskService.AddTask(task));

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> getTask([FromRoute] Guid id) 
        {
            var task = await taskService.getTask(id);   
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            var task = await taskService.DeleteTask(id);    
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }


        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> UpdateTask([FromRoute] Guid id, Task task)
        {
            Task updatedTask = await taskService.UpdateTask(id, task);
            if (updatedTask == null)
            {
                return NotFound();
            }
            return Ok(updatedTask);
        }


        //[Route("[action]/{statusOfTask}")]
        //[HttpGet]
        //public ActionResult<int> GetTaskInfo(string statusOfTask)
        //{
        //    if (statusOfTask == "completed")
        //    {
        //        return 5;
        //    }
        //    else if (statusOfTask == "assigned")
        //    {
        //        return 14;
        //    }
        //    return -1;
        //}

    }
}
