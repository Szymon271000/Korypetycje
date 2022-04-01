using CheckList.Data;
using CheckList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private List<Goal> Done = new List<Goal>();
        private readonly ICategoryRepository categoryRepository;

        public HomeController(ILogger<HomeController> logger, ITaskRepository taskRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.taskRepo = taskRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View();
            var categories = categoryRepository.GetAllCategories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
        }

        [HttpPost]
        public IActionResult Index(TaskViewModel model)
        {
            var categories = categoryRepository.GetAllCategories();
            var cate = categories.Find(x => x.Id == model.cat);
            if (cate == null)
            {
                return NotFound("Category not found");
            }
            if (ModelState.IsValid)
            {
                var goal = new Goal
                {
                    Description = model.Description,
                    Duration = model.Duration,
                    Category = model.Category,
                    cat = cate
                    
                };
                taskRepo.AddTask(goal);
                return RedirectToAction("Tasks");
            }
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
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


        public IActionResult SetDone(int id)
        {
            taskRepo.SetDone(id);
            return RedirectToAction("Tasks");
        }


        //public IActionResult TaskDone()
        //{
        //    return View(taskRepo.GetDone());
        //}

        public IActionResult SetUnDone(int id)
        {
            taskRepo.SetUnDone(id);
            return RedirectToAction("Tasks");
        }

        public IActionResult Remove(int id)
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
