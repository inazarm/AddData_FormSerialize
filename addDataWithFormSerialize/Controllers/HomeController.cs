using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using addDataWithFormSerialize.Models;
namespace addDataWithFormSerialize.Controllers
{
    public class HomeController : Controller
    {
        employeeDBEntities db = new employeeDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(EmployeeInfo employeeInfo)
        {
            if (ModelState.IsValid)
            {
                db.EmployeeInfoes.Add(employeeInfo);
                db.SaveChanges();
                return Json(new {data=employeeInfo },JsonRequestBehavior.AllowGet);
            }

            return View(employeeInfo);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}