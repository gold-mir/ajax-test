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
        public ActionResult Heck(int numberOfHecks, Dictionary<string, Object> data)
        {
            List<string> keys = new List<string>(data.Keys);
            Console.WriteLine(keys.Count);
            foreach (string s in keys)
            {
                Console.WriteLine(s);
                Console.WriteLine(data[s]);
            }
            Helper.GiveSomeHecks(numberOfHecks);

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("hecks", Helper.HeckCount);
            dict.Add("current-hecks", numberOfHecks);

            return Json(dict);
        }
    }
}
