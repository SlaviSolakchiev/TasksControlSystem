namespace TasksControlSystem.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class TaskController : BaseController
    {
        public IActionResult CreateTask()
        {
            return this.View();
        }
    }
}
