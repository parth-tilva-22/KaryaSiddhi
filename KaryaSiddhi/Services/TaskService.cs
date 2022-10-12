using Task = KaryaSiddhi.Models.Task;

namespace KaryaSiddhi.Services
{
    public class TaskService
    {
        static List<Task> Tasks { get; set; }
        static TaskService()
        {
            Tasks = new List<Task>
            {
                new Task {
                    Title= "Test the webapi created with asp.net",
                    Description= "This data is coming from in-memory data caching service A further longer description is possible.",
                    DueDate= "26th aug 2022",
                    IsComplete= true,
                    Priority= 1,
                },new Task {
                    Title= "Completed budgeting for FY 2023",
                    Description= "This data is coming from in-memory data caching service is required by the finance depeartment. A further longer description is possible.",
                    DueDate= "26th aug 2022",
                    IsComplete= true,
                    Priority= 1,
                },new Task {
                    Title= "Completed budgeting for FY 2023",
                    Description= "Budgeting for FY 2023 this is required by the finance depeartment. A further longer description is possible.",
                    DueDate= "26th aug 2022",
                    IsComplete= true,
                    Priority= 1,
                },new Task {
                    Title= "Completed budgeting for FY 2023",
                    Description= "Budgeting for FY 2023 this is required by the finance depeartment. A further longer description is possible.",
                    DueDate= "26th aug 2022",
                    IsComplete= true,
                    Priority= 1,
                },new Task {
                    Title= "Completed budgeting for FY 2023",
                    Description= "Budgeting for FY 2023 this is required by the finance depeartment. A further longer description is possible.",
                    DueDate= "26th aug 2022",
                    IsComplete= true,
                    Priority= 1,
                },

            };

        }

        public static List<Task> GetAll() => Tasks;
    }
}
