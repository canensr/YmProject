using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System.EnterpriseServices;
using EntityLayer.Concrete;
using System.Web.UI;

namespace DoodleProject.Controllers
{
    
    public class HomeController : Controller
    {
        // GET: Home
        Context a = new Context();
        ActivityManager am = new ActivityManager();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HomeList()
        {
            return PartialView();
        }

        [Authorize]
        [HttpGet]
        public ActionResult Etkinlik(string ActivitySubject, string ActivityExplanation, string ActivityDuration, string ActivityDate)
        {
            //ViewBag.ActivitySubject = ActivitySubject;
            //ViewBag.ActivityExplanation = ActivityExplanation;
            //ViewBag.ActivityDuration = ActivityDuration;
            //ViewBag.ActivityDate = ActivityDate;

            Context c = new Context();
            List<SelectListItem> values = (from x in c.Activities.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.ActivitySubject,
                                               Value = x.ActivityID.ToString()
                                           }).ToList();
            ViewBag.values = values;

            List<SelectListItem> values2 = (from x in c.Activities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.ActivityExplanation,
                                                Value = x.ActivityID.ToString()
                                            }).ToList();
            ViewBag.values2 = values2;

            List<SelectListItem> values3 = (from x in c.Activities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.ActivityDuration,
                                                Value = x.ActivityID.ToString()
                                            }).ToList();
            ViewBag.values2 = values3;

            List<SelectListItem> values4 = (from x in c.Activities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = x.ActivityDate,
                                                Value = x.ActivityID.ToString()
                                            }).ToList();
            ViewBag.values2 = values4;


            return View();
        }
        [HttpPost]
        public ActionResult Etkinlik(EntityLayer.Concrete.Activity c)
        {
            am.ActivityAddBL(c);

            return RedirectToAction("ActivityByList","Activity");
        }
        public ActionResult ActivityByList(int id)
        {
            var bloglist = am.GetAll();
            return View(bloglist);
        }


    }
}