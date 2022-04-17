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
public class DetailsController : Controller
{
    employeeEntities db = new employeeEntities();
    // GET: Day
    public ActionResult Index()
    {
        List<employee_salary_details> data = db.employee_salary_details.ToList();
        return View(data);
    }
    public ActionResult create()
    {
        var emplist = db.employees.ToList();
        ViewBag.employeeList=new SelectList(emplist, "Eid", "Ename");
        return View();
    }
    public ActionResult Savedata(employee_salary_details salary)
    {

        db.employee_salary_details.Add(salary) ;
        db.SaveChanges();
        return RedirectToAction("Index");

    }
    public ActionResult updatedata(employee_salary_details salary)
    {

        db.Entry(salary).State=EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");

    }
    public ActionResult Edit(int id)
    {
        employee_salary_details data = db.employee_salary_details.Find(id);
        return View(data);


    }
    public ActionResult deletedata(int id)
    {
        employee data = db.employees.Find(id);
        db.employees.Remove(data);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public ActionResult Index(DateTime dte,DateTime date,String dte)
    {
        var results = db.employee_salary_details.Where(x => x.paid_date>=dte && x.paid_date<=date && x.employee.Ename==dte).ToList();
        return View(results);
    }

}
