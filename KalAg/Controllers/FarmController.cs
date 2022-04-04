using KalAg.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace KalAg.Controllers
{
    public class FarmController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public FarmController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Cows()
        {
            return View();
        }

        public IActionResult Chickens()
        {
            return View();
        }
        public IActionResult Eggs()
        {
            return View();
        }

        public IActionResult Weeding()
        {
            return View();
        }
        public IActionResult Seeding()
        {
            return View();
        }

        public IActionResult Fertilizer()
        {
            return View();
        }
        public IActionResult Bees()
        {
            return View();
        }

        public IActionResult Pigs()
        {
            return View();
        }
        public IActionResult Barn()
        {
            return View();
        }
    }
}
