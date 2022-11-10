using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ajaxgetting2022.Models;
namespace ajaxgetting2022.Controllers
{
    public class HomeController : Controller
    {
        ajaxDBEntities db = new ajaxDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            //2022 changes      
            return View();
        }
        public ActionResult AddBatch()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBatch(batchtb tb)
        {
            try
            {
                db.batchtbs.Add(tb);
                db.SaveChanges();
                ViewBag.msg = "Data Save";
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.ToString();
            }
            return View();
        }

        public ActionResult AddStudent()
        {
            ViewBag.batchID = new SelectList(db.batchtbs, "BatchID", "BatchName");
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(studenttb st)
        {
            try
            {
                ViewBag.batchID = new SelectList(db.batchtbs, "BatchID", "BatchName");
                db.studenttbs.Add(st);
                db.SaveChanges();
                ViewBag.msg = "Data Save";
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.ToString();
            }
            return View();
        }

        public ActionResult StudentReport()
        {
            var getbatch = db.batchtbs.ToList();
            return View(getbatch);
        }

        public PartialViewResult ShowStudentReport(int id)
        {
            var gets = db.studenttbs.Where(x => x.BatchIDKF == id).ToList();
            return PartialView(gets);
        }

    }
}
