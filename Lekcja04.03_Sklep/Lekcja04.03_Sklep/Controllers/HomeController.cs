using Lekcja04._03_Sklep.Data;
using Lekcja04._03_Sklep.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
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

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, IOrderReposiotry orderReposiotry)
        {
            _logger = logger;
            this.productRepository = productRepository;
            this.orderReposiotry = orderReposiotry;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
            var orderList = orderReposiotry.GetItemsFromActiveOrder();
            ViewBag.OrderCount = orderList.Count;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ProductModelView model)
        {
            if(ModelState.IsValid)
            {
                var product = new Product
                {
                    Name = model.Name,
                    Price = model.Price
                };
                productRepository.AddProduct(product);
                return RedirectToAction("Products");
            }
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
