using Lekcja14._02.Data;
using Lekcja14._02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lekcja14._02.Controllers
{
    public class ItemController : Controller
    {
        private readonly AppDbContext context;

        public ItemController(AppDbContext context) //dependency injection
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var list = context.Items.ToList();
            return View(list);
        }

        public IActionResult Create()
        {
            return View(new ItemViewModel());
        }

        [HttpPost]
        public IActionResult Create(ItemViewModel model)
        {
            if(ModelState.IsValid)
            {
                var item = new Item
                {
                    Category = model.Category,
                    Name = model.Name,
                    Price = model.Price
                };
                context.Add(item);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var item = context.Items.FirstOrDefault(x => x.Id == id);
            if(item == null)
            {
                return NotFound("Item not found");
            }

            context.Remove(item);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var item = context.Items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound("Item not found");
            }
            var model = new ItemViewModel
            {
                Category = item.Category,
                Name = item.Name,
                Price = item.Price
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(int id, ItemViewModel model)
        {
            var item = context.Items.FirstOrDefault(x => x.Id == id);
            if (item == null)
            {
                return NotFound("Item not found");
            }

            if (ModelState.IsValid)
            {
                item.Category = model.Category;
                item.Name = model.Name;
                item.Price = model.Price;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
