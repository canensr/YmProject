using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Mail
    {



        public void mail(string sendMailAdress, string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            MailAddress from = new MailAddress("mailadresi@gmail.com");
            MailAddress to = new MailAddress("ensarcan57@gmail.com");//bizim mail adresi
            MailMessage msg = new MailMessage(from, to);
            msg.IsBodyHtml = true;
            msg.Subject = subject;
            msg.Body += "Gönderen Mail Adresi " + to + " | <h1> " + body + " </h1>"; //burada başında gönderen kişinin mail adresi geliyor
            msg.CC.Add(sendMailAdress);//herkes görür
            NetworkCredential info = new NetworkCredential("ensarcan57@gmail.com", "gyhrbqzyqwmzaemz");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = info;
            client.Send(msg);

        }
    }

}
