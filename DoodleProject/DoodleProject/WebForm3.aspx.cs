using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DoodleProject
{
    
    public partial class WebForm3 : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
        }
        ActivityManager am = new ActivityManager();
        public ActionResult ActivityByList()
        {
            var bloglist = am.GetAll();
            return View(bloglist);
        }

        private ActionResult View(List<Activity> bloglist)
        {
            throw new NotImplementedException();
        }
    }
}