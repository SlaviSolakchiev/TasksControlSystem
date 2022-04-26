namespace TasksControlSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TasksControlSystem.Data.Common.Models;

    public class Status : BaseDeletableModel<int>
    {
        public string Name { get; set; }
    }
}
