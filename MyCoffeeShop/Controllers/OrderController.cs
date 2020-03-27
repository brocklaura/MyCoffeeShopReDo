using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoffeeShop.Models;

namespace MyCoffeeShop.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult Index(int? id)
        {
            ViewData["id"] = id;
            return View("OrderIndex");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Order(UserOrder order)
        {
            if (ModelState.IsValid)
            {
                double price = MenuItems.itemPrice;

                if (order.Type.Contains("+$1"))
                {
                    price += 1;
                }

                price =+ .01555;
                //price = order.Total;
                return View(order);
            }

            else
            {
                ViewData["errorMsg"] = "Your form had erros. Please correcr and re-submit.";
                return View("OrderIndex", order);
            }


        }
    }
}