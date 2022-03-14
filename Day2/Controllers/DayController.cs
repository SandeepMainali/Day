using Day2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    }
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
        public ActionResult updatedata(employee employee)
        {
           
            db.Entry(employee).State=EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    public ActionResult Edit(int id)
    {
        employee data = db.employees.Find(id);
        return View(data);


    }
    }