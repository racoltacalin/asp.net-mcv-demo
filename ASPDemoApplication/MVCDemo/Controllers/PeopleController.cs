using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;

            return View();
        }

        public ActionResult ListPeople()
        {
            List<PersonModel> people = new List<PersonModel>();

            people.Add(new PersonModel { FirstName = "Clain", LastName = "Rvc", Age = 23 });
            people.Add(new PersonModel { FirstName = "John", LastName = "Metusala", Age = 45 });
            people.Add(new PersonModel { FirstName = "Arron", LastName = "Cadrinc", Age = 45 });
            people.Add(new PersonModel { FirstName = "Elemental", LastName = "Durvonik", Age = 45 });

            return View(people);
        }
    }
}