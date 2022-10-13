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




















        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTask(Guid id)
        //{
        //    var task = await karyaSiddhiDbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id);
        //    if(task == null)
        //    {
        //        return NotFound();  
        //    }
        //    var removedTask = karyaSiddhiDbContext.Tasks.Remove(task);
        //    return Ok(removedTask);    
        //}




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
