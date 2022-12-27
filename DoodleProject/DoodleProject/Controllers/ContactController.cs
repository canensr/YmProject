
using BusinessLayer;
using DoodleProject.Models;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace DoodleProject.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Contact model)
        {
            MailMessage mailim = new MailMessage();
            mailim.To.Add("ensarcan57@gmail.com");  //maillerin gideceği adres
            mailim.From = new MailAddress("ensarcan57@gmail.com");
            mailim.Subject = "Bize Ulaşın Sayfasından ' "+ model.Mail +" ' Mail Adresine Sahip Kullanıcıdan Mesajınız Var ' " + model.Subject + " '";
            mailim.Body = "Sayın yetkili, ' " + model.Name + " ' kişisinden gelen mesajın içeriği aşağıdaki gibidir. <br><br>" + model.Message;
            mailim.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("ensarcan57@gmail.com", "nwfuhdsggixnzwgg");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mailim);
                TempData["Message"] = "Mesajınız iletilmiştir. En kısa zamanda size geri dönüş sağlanacaktır.";
            }
            catch (Exception ex)
            {

                TempData["Message"] = "Mesaj gönderilemedi. Hata nedeni;" + ex.Message;
            }

            return View();
        }






    }
}