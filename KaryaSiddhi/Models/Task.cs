namespace KaryaSiddhi.Models
{
    public class Task
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public bool IsComplete { get; set; }
        public int Priority { get; set; }

    }
}
