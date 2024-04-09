using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
    public class Lab1Controller : Controller
    {
        public string Index()
        {
            return DateTime.Now.Hour < 12 ? "Good morning" : "Good afternoon";
        }

        public string Get(string get) => ModelClass.Hello() + get;
    }

    public class Lab2Controller : Controller
    {
        private static PersonRepository personDB = new PersonRepository();
        public ViewResult Index()
        {
            ViewBag.Greeting = ModelClass.Hello();
            ViewData["Message"] = "have a good mood";
            return View();
        }
        [HttpGet]
        public ViewResult InputData() => View();
        [HttpPost]
        public ViewResult InputData(Person person) {
            personDB.AddResponse(person);
            return View("Hello", person);
        }
        public ViewResult OutputData() { 
            ViewBag.Persons = personDB.GetAllResponses; 
            ViewBag.Count = personDB.NumberOfPerson; 
            return View("ListPerson"); 
        }
    }
    public class Lab3Controller : Controller
    {
        private static PersonRepository personDB = new PersonRepository();
        public ViewResult Index()
        {
            ViewBag.Greeting = ModelClass.Hello();
            ViewData["Message"] = "have a good mood";
            return View();
        }
        [HttpGet]
        public ViewResult InputData() => View();
        [HttpPost]
        public ViewResult InputData(Person person)
        {
            personDB.AddResponse(person);
            return View("Hello", person);
        }
        public ViewResult OutputData()
        {
            ViewBag.Persons = personDB.GetAllResponses;
            ViewBag.Count = personDB.NumberOfPerson;
            return View("ListPerson");
        }
    }

    public class Lab4Controller : Controller
    {
        private static PersonRepository personDB = new PersonRepository();
        public ViewResult Index()
        {
            ViewBag.Greeting = ModelClass.Hello();
            ViewData["Message"] = "have a good mood";
            return View();
        }
        [HttpGet]
        public ViewResult InputData() => View();
        [HttpPost]
        public ViewResult InputData(Person person)
        {
            personDB.AddResponse(person);
            return View("Hello", person);
        }
        public ViewResult OutputData()
        {
            ViewBag.Persons = personDB.GetAllResponses;
            ViewBag.Count = personDB.NumberOfPerson;
            return View("ListPerson");
        }
    }
}
