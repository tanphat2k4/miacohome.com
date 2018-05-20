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
        public ActionResult ContactsPage(RenderModel model)
        {
            if (Request.HttpMethod == "POST")
            {
                var fullName = Request["name"];
                var Email = Request["email"];
                var subject = Request["subject"];
                var message = Request["message"];
                var dateNow = string.Format("[0]-[1]", DateTime.Now.ToString());
                //Creat Service
                var contentServices = Services.ContentService;
                var person = contentServices.CreateContent(fullName, model.Content.Id, "potential_Customer");
                //SendMail(model);
                //Creat Person
                person.SetValue("name_customer", fullName);
                person.SetValue("email_customer", Email);
                person.SetValue("subject", subject);
                person.SetValue("message", message);
                
                //refesh page
                contentServices.SaveAndPublishWithStatus(person);
            }
            return CurrentTemplate(model);
        }
        //public ActionResult HandleSubmitForm(ContactModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var contentServices = Services.ContentService;
        //        var message = Services.ContentService.CreateContent(String.Format("{0}-{1}", model.name, DateTime.Now.ToString()), CurrentPage.Id, "potential_Customer");
        //        message.SetValue("name_customer", model.name);
        //        message.SetValue("email_customer", model.email);
        //        message.SetValue("message", model.message);
        //        message.SetValue("subject", model.subject);
        //        //refesh page
        //        contentServices.SaveAndPublishWithStatus(message);
      
        //    }
        //    return CurrentTemplate(model);
        //}
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