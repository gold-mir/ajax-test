using Microsoft.AspNetCore.Mvc;
using System;
using Test.Models;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/rand")]
        public int RandomNumber()
        {
            int number = Helper.GetRandomNumber();
            Console.WriteLine($"Heckin got a random number and it was {number}!");
            return number;
        }

        [HttpPost("/heck")]
        public ActionResult Heck(int numberOfHecks)
        {
            Helper.GiveSomeHecks(numberOfHecks);
            string[] hecks = new string[Helper.HeckCount];
            for(int i = 0; i < hecks.Length; i++)
            {
                hecks[i] = $"Heck the number {i + 1}";
            }

            return Json(hecks);
        }
    }
}
