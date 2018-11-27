using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult Firma_de_transport_reparatii()
        {
            return View("~/Views/AboutUs/Firma-de-transport-reparatii.cshtml");
        }
    }
}