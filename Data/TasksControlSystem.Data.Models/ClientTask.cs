namespace TasksControlSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using TasksControlSystem.Data.Common.Models;

    public class ClientTask : BaseDeletableModel<string>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public DateTime Deadline { get; set; }

        public double Budget { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int StatusId { get; set; }

        public Status Status { get; set; }
    }
}
