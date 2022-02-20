using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Lab1_2try2.Models;

namespace Lab2_1.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DA = 0;
            ViewBag.TL = 0;
            return View();
        }

        public IActionResult Index(PriceQuotationModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DA = model.CalculateDiscountAmount();
                ViewBag.TL = model.CalculateTotal();
            }
            else
            {
                ViewBag.DA = 0;
                ViewBag.TL = 0;
            }
            return View(model);
        }

       
    }
}

