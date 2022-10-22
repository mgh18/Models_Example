using Models_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Models_Example.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
        
            return View(Repository.people);
        }

        public ActionResult detail(int id)
        {
            Person p = Repository.people.Single(per=>per.Id == id);
            return View(p);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Person person)
        {
           
            person.Id = Repository.people.Max(p=>p.Id) + 1;
            Repository.people.Add(person);
           
            return RedirectToAction("index");
        }
        public ActionResult edit(int id)
        {
            Person person = Repository.people.SingleOrDefault(p => p.Id == id);
            if (person == null)
                return HttpNotFound();
            return View(person);
        }
        [HttpPost]
        public ActionResult edit(Person person)
        {
            int index = Repository.people.FindIndex(p => p.Id == person.Id);
            Repository.people[index] = person;
            return RedirectToAction("index");
        }

        public ActionResult delete(int id)
        {
            if (id == Repository.people.Min(p=>p.Id))
            {
                return RedirectToAction("index");
            }
            else
            {
                int index = Repository.people.FindIndex(p => p.Id == id);
                Repository.people.RemoveAt(index);
                return RedirectToAction("index");
            }


        }

    }
}