using GitFlow.Models;
using GitFlow.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitFlow.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            DataRepository EmpRepo = new DataRepository();
            return View(EmpRepo.GetAllPersons());
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPerson(PersonRequest person)
        {
            try
            {
                DataRepository EmpRepo = new DataRepository();
                EmpRepo.AddPerson(person);

                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }

        public ActionResult GetAllPersons()
        {
            DataRepository EmpRepo = new DataRepository();
            return View(EmpRepo.GetAllPersons());
        }

        public ActionResult EditPerson(int id)
        {
            DataRepository EmpRepo = new DataRepository();
            return View(EmpRepo.GetAllPersons().Find(Emp => Emp.Id_Person == id));
        }

        [HttpPost]
        public ActionResult EditPerson(Person person)
        {
            try
            {
                DataRepository EmpRepo = new DataRepository();

                EmpRepo.UpdatePerson(person);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeletePerson(int id)
        {
            try
            {
                DataRepository EmpRepo = new DataRepository();
                if (EmpRepo.DeletePerson(id))
                {
                    ViewBag.AlertMsg = "Person details deleted successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}