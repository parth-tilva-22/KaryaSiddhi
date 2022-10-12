using KaryaSiddhi.Data;
using KaryaSiddhi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly KaryaSiddhiDbContext karyaSiddhiDbContext;

        public TaskController(KaryaSiddhiDbContext karyaSiddhiDbContext)
        {
            this.karyaSiddhiDbContext = karyaSiddhiDbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            var tasks = await karyaSiddhiDbContext.Tasks.ToListAsync();
            return Ok(tasks);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(Guid id)
        {
            var task = await karyaSiddhiDbContext.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            if(task == null)
            {
                return NotFound();  
            }
            var removedTask = karyaSiddhiDbContext.Tasks.Remove(task);
            return Ok(removedTask);    
        }


        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> getTask([FromRoute] Guid id)
        {
            var task = await karyaSiddhiDbContext.Tasks.FirstOrDefaultAsync(t => t.Id == id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);

        }

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateTask([FromRoute])


        




        [HttpPost]
        public async Task<IActionResult> AddTask([FromBody] Task task)
        {
            task.Id = Guid.NewGuid();
            await karyaSiddhiDbContext.Tasks.AddAsync(task);
            await karyaSiddhiDbContext.SaveChangesAsync();
            return Ok(task);

        }


        //[HttpGet("{statusOfTask}")]
        //public ActionResult<int> getxyzdoesnotmatter(string statusOfTask)
        //{
        //    if(statusOfTask == null)
        //    {
        //        return 0;
        //    }else if(statusOfTask == "completed")
        //    {
        //        return 5;
        //    }else if(statusOfTask == "assigned")
        //    {
        //        return 55;
        //    }
        //    return -1;
        //}

        [Route("[action]/{statusOfTask}")]
        [HttpGet]
        public ActionResult<int> GetTaskInfo(string statusOfTask)
        {
            if (statusOfTask == "completed")
            {
                return 5;
            }
            else if (statusOfTask == "assigned")
            {
                return 14;
            }
            return -1;
        }

    }
}
