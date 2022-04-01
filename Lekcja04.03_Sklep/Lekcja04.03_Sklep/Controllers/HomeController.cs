using Lekcja04._03_Sklep.Data;
using Lekcja04._03_Sklep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lekcja04._03_Sklep.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository productRepository;
        private readonly IOrderReposiotry orderReposiotry;
        private readonly ICategoryRepository categoryRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, IOrderReposiotry orderReposiotry, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
            this.orderReposiotry = orderReposiotry;
            this.categoryRepository = categoryRepository;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var orderList = orderReposiotry.GetItemsFromActiveOrder();
            ViewBag.OrderCount = orderList.Count;
        }

        public IActionResult Index()
        {
            var categories = categoryRepository.GetAllCategories();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProductModelView model)
        {
            var categories = categoryRepository.GetAllCategories();
            var cat = categories.Find(x => x.Id == model.Category);
            if(cat == null)
            {
                return NotFound("Category not found");
            }

            if (ModelState.IsValid)
            {
                var product = new Product
                {
                    Name = model.Name,
                    Price = model.Price,
                    Category = cat
                };
                productRepository.AddProduct(product);
                return RedirectToAction("Products");
            }

            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View(model);
        }


        public IActionResult Products()
        {
            return View(productRepository.GetAllProducts());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AddProduct(int id)
        {
            orderReposiotry.AddProductToOrder(id);
            return RedirectToAction("Products");
        }

        public IActionResult Basket()
        {
            var orderList = orderReposiotry.GetItemsFromActiveOrder();
            return View(orderList);
        }

        public IActionResult DeleteOrderItem(int id)
        {
            orderReposiotry.RemoveOrderItem(id);
            return RedirectToAction("Basket");
        }
    }
}
