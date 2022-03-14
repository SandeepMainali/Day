using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class MyController : Controller
    {
        Models.employeeEntities db = new employeeEntities();
        // GET: My
        public ActionResult Index2()
        {
            List<mainali> data = db.mainalis.ToList();
            return View(data);
        }
        public ActionResult Add()
        {
           
            return View();
        }
        public ActionResult Savedata(mainali tbl_sandip)
        {

            db.mainalis.Add(tbl_sandip);
            db.SaveChanges();
            return RedirectToAction("Add");
        }
    }
}
