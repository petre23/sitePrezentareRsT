using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Companie_de_transport_reparatii_contact()
        {
            return View("~/Views/Contact/Companie-de-transport-reparatii-contact.cshtml");
        }
    }
}