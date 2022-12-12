using GitFlow.Models;
using GitFlow.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitFlow.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee/AddEmployee
        public ActionResult AddEmployee()
        {
            return View();
        }

        // POST: Employee/AddEmployee
        [HttpPost]
        public ActionResult AddEmployee(EmployeeRequest employee)
        {
            try
            {
                DataRepository EmpRepo = new DataRepository();
                EmpRepo.AddEmployee(employee);

                ViewBag.Message = "Records added successfully.";

                return View();
            }
            catch
            {
                return View("Index");
            }
        }
    }
}