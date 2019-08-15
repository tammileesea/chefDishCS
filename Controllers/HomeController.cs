using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using chefDish.Models;

namespace chefDish.Controllers
{
    public class HomeController : Controller
    {
        private chefAndDishContext dbContext;
        public HomeController(chefAndDishContext context) {
            dbContext = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("new")]
        public IActionResult New(){
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
