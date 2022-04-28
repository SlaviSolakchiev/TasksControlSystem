namespace TasksControlSystem.Web.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using TasksControlSystem.Data.Common.Repositories;
    using TasksControlSystem.Data.Models;
    using TasksControlSystem.Services.Data;
    using TasksControlSystem.Web.ViewModels;

    public class TaskController : BaseController
    {
        private readonly IGetCategoriesService getCategoriesService;
        private readonly IGetLocationsService getLocationsService;
        private readonly ICreateTaskService createTaskService;

        public TaskController(IGetCategoriesService getCategoriesService, IGetLocationsService getLocationsService, ICreateTaskService createTaskService)
        {
            this.getCategoriesService = getCategoriesService;
            this.getLocationsService = getLocationsService;
            this.createTaskService = createTaskService;
        }

        [HttpGet]
        public IActionResult CreateTask()
        {
            var categoriesItems = this.getCategoriesService.GetCategories();
            var locationItems = this.getLocationsService.GetLocations();

            var viewModel = new CreateTaskInputModel();
            viewModel.Locations = locationItems;
            viewModel.Categories = categoriesItems;

            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult CreateTask(CreateTaskInputModel input)
        {
            if (this.ModelState.IsValid)
            {
                this.createTaskService.CreateTask(input);
            }
            return this.View();
        }
    }
}
