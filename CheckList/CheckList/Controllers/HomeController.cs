using CheckList.Data;
using CheckList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CheckList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITaskRepository taskRepo;

        public HomeController(ILogger<HomeController> logger, ITaskRepository taskRepository)
        {
            _logger = logger;
            this.taskRepo = taskRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TaskViewModel model)
        {
            if (ModelState.IsValid)
            {
                var goal = new Goal
                {
                    Description = model.Description,
                    Duration = model.Duration,
                    Category = model.Category
                };
                taskRepo.AddTask(goal);
                return RedirectToAction("Tasks");
            }
            return View(model);
        }

        public IActionResult Tasks()
        {
            return View(taskRepo.GetAllGoals());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RemoveTask(int id)
        {
            taskRepo.RemoveGoal(id);
            return RedirectToAction("Tasks");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
