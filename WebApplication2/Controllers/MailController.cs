using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class MailController : ApiController
    {

        [System.Web.Http.HttpPost]
        [System.Web.Http.ActionName("SendMail")]
        public string PostSendMail(Mail mail)
        {
            if (ModelState.IsValid)
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.To.Add(mail.From);
                mailMessage.From = new MailAddress(mail.From);
                mailMessage.Subject = mail.Subject;
                string Body = mail.Content;
                mailMessage.Body = Body;
                mailMessage.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("hotelaurora2017@gmail.com", "2017hotelaurora");
                smtp.EnableSsl = true;
                smtp.Send(mailMessage);

                return "Send";
            }
            else
            {
                return "Error";
            }
        }
    }

}
