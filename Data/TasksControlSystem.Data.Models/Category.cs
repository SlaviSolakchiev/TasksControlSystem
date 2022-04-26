namespace TasksControlSystem.Data.Models
{
    using TasksControlSystem.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}