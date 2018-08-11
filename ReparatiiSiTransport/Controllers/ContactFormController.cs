using ReparatiiSiTransport.Helper;
using ReparatiiSiTransport.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class ContactFormController : Controller
    {
        // GET: ContactForm
        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(EmailModel email)
        {
            return Json(new { successful = new EmailProcessor().SendEmail(email).ToString()}, JsonRequestBehavior.AllowGet);
        }
    }
}