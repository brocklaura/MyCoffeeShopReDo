using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoffeeShop.Models;

namespace MyCoffeeShop.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("RegisterIndex");
        }

        [HttpPost]
        public IActionResult Register(UserOrder register)
        {
            ViewData["name"] = register.FirstName + " " + register.LastName;
            ViewData["email"] = register.Email;
            return View(register);
        }

    }
}