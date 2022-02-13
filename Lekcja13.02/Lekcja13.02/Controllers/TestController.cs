using Lekcja13._02.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Lekcja13._02.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Help()
        {
            var person = new Person
            {
                Name = "Jan",
                Surname = "Kowalski",
                Age = 20
            };
            return View(person);
        }

        public IActionResult AccountRegister()
        {
            return View(new Person());
        }

        [HttpPost]
        public IActionResult AccountRegister(Person person)
        {
            if(ModelState.IsValid) //daje true jestli obiekt person zostal poprawnie wypelniony danymi, zgodanie z jego atrybutami np [Required] itp
            {
                System.IO.File.WriteAllText("dane.txt", person.Name + " " + person.Surname + " " + person.Age);
            }
            
            return View(person);
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel _login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(_login);
        }
    }
}

// 1 model do logowania
// 2 akcja z logowania
// 3 view do logowania
// 4 akcja po kliknieciu po uzupelnieniu formularza [HttpPost]

//GET - pobierz cos z serwera (np pobiera widok formularza)
//POST - dodaj cos na serwer (np. wysyla dane z formularza)
//PUT - aktualizuj cos na serwerze
//DELETE - skasuj cos

//CRUD

//CREATE (POST) - INSERT INTO
//READ (GET) - SELECT
//UPDATE (PUT) - UPDATE
//DELETE (DELETE) - DROP
