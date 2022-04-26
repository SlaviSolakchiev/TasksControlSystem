namespace TasksControlSystem.Data.Models
{
    using TasksControlSystem.Data.Common.Models;

    public class Location : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public bool IsReserved { get; set; }
    }

}