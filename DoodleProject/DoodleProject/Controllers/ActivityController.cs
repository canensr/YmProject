using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoodleProject.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activity
        ActivityManager am = new ActivityManager();
        
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult ActivityGetir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActivityGetir(string ActivitySubject,string Explanation,string ActivityDuration,string ActivityDate)
        {

            var activityList = am.GetAll();
            return View(activityList);
        }
        public ActionResult ActivityByList()
        {
            var bloglist = am.GetAll();
            return View(bloglist);
        }
    }
}