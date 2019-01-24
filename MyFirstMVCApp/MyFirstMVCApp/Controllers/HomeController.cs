using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(int firstYear, int secondYear)
        {
            return RedirectToAction("Results", new { firstYear, secondYear});
        }

        public IActionResult Results(int firstYear, int secondYear)
        {
            // do what we want with the numbers
            return View(TimePerson.GetPersons(firstYear, secondYear));
        }
    }
}
