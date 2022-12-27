using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace DoodleProject.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            
            var adminuserinfo=c.Admins.FirstOrDefault(x=>x.UserName == p.UserName && x.Password == p.Password);
            if(adminuserinfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserinfo.UserName, false);
                Session["Mail"] = adminuserinfo.UserName;
                Session["AdminID"] = adminuserinfo.AdminID;
                return RedirectToAction("Index","Home");
            }
            ViewBag.hata = "Mail veya Şifreniz Hatalı...";
            return View(p);
  
        }
        [HttpPost]
        public ActionResult Register(Admin p)
        {
            if(ModelState.IsValid)
            {
                c.Admins.Add(p);
                
                c.SaveChanges();
                return RedirectToAction("Index","Login");
            }
            ModelState.AddModelError("", "Hatalı");
            return View("Login",p);
        }
        public ActionResult LogOut()  //çıkış işlemleri
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}