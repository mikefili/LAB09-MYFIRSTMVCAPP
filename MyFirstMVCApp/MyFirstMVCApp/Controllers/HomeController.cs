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

        public IActionResult Index(int begYear, int endYear)
        {
            return RedirectToAction("Results", new { begYear, endYear});
        }

        public IActionResult Results(int begYear, int endYear)
        {
            // do what we want with the numbers
            return View(TimePerson.GetPersons(begYear, endYear));
        }
    }
}
