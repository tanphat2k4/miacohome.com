using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using Umbraco.Web.Models;
using System.Net.Mail;
using System.Configuration;
using Umbraco.Core.Services;
using miacohome.com.Models;

namespace miacohome.com.Controllers
{
    public class cONTACTSController : RenderMvcController
    {
        // GET: cONTACTS
        public ActionResult ContactsPage(ContactModel model)
        {
            if (Request.HttpMethod == "POST")
            {
                
                //Creat Service
                var contentServices = Services.ContentService;
                var person = contentServices.CreateContent(model.name, CurrentPage.Id, "potential_Customer");
                //Creat Person
                person.SetValue("name_customer", model.name);
                person.SetValue("email_customer", model.email);
                person.SetValue("subject", model.subject);
                person.SetValue("message", model.message);
                SendMail(model);
                //refesh page
                contentServices.SaveAndPublishWithStatus(person);
            }
            return CurrentTemplate(model);
        }
       
        private void SendMail(ContactModel model)
        {
            var formEmail = new MailAddress(System.Configuration.ConfigurationManager.AppSettings["sendEmailForm"]);
            var formPassword = System.Configuration.ConfigurationManager.AppSettings["EmailPassword"];
            var toAddress = new MailAddress("phat.nguyentan710202@gmail.com");
            string subject = ConfigurationManager.AppSettings["EmailSubject"];
            string body = model.message;
            var message = new MailMessage(formEmail, toAddress)
            {
                Subject = subject,
                Body = body
            };
            //connect ro SMTP credentials in web.config
            try
            {
                var smtp = new SmtpClient();
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}