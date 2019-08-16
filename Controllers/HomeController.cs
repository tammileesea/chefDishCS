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
        public IActionResult Index() {
            List<Chef> AllChefs = dbContext.chefs.Include(c => c.Dishes).ToList();
            ViewBag.chefs = AllChefs;
            return View();
        }

        [HttpGet("new")]
        public IActionResult New() {
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult addChef(Chef newChef){
            if (ModelState.IsValid){
                DateTime today = DateTime.Now;
                DateTime DOB = newChef.Birthday;
                int age = today.Year - DOB.Year;
                if ((DOB.Month > today.Month) || (DOB.Month == DateTime.Now.Month && DOB.Day > today.Day)){
                    age--;
                }
                newChef.Age = age;
                dbContext.Add(newChef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("New");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes() {
            List<Dish> AllDishes = dbContext.dishes.Include(c => c.Cook).ToList();
            ViewBag.dishes = AllDishes;
            return View();
        }

        [HttpGet("dishes/new")]
        public IActionResult NewDish(){
            List<Chef> AllChefs = dbContext.chefs.ToList();
            ViewBag.chefs = AllChefs;
            return View();
        }

        [HttpPost("addDish")]
        public IActionResult addDish(Dish newDish){
            if (ModelState.IsValid) {
                System.Console.WriteLine("****************************");
                System.Console.WriteLine("NEW DISH WORKING");
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return View("NewDish");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
