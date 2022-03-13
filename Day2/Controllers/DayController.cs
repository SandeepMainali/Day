using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class DayController : Controller
    {
        employeeEntities db = new employeeEntities();
        // GET: Day
        public ActionResult Index()
        {
            List<employee> data = db.employees.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Savedata(employee tbl_sandeep)
        {

            db.employees.Add(tbl_sandeep);
            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
    }
}