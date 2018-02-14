using Microsoft.AspNetCore.Mvc;
using System;
using Test.Models;
using System.Collections.Generic;

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
        public ActionResult Heck(int numberOfHecks, Dictionary<string, string> data)
        {
            try
            {
                foreach (KeyValuePair<string, string> pair in data)
                {
                    Console.WriteLine($"Key: {pair.Key} Value: {pair.Value}");
                }
            } catch (Exception e)
            {
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Source: {e.Source}");
                Console.WriteLine($"StackTrace: {e.StackTrace}");
            }


            Helper.GiveSomeHecks(numberOfHecks);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("hecks", Helper.HeckCount);
            dict.Add("current-hecks", numberOfHecks);

            Cat cat = new Cat("Catto");
            cat.favoriteFoods.Add("Muffins");
            cat.favoriteFoods.Add("Mice");
            cat.data.Add("Number of Monkeys", "Three Monkeys");

            return Json(cat);
        }
    }
}
