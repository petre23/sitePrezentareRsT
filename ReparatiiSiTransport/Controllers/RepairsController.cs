using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class RepairsController : Controller
    {
        // GET: Repairs
        public ActionResult Firma_reparatii_auto_masini()
        {
            return View("~/Views/Repairs/Firma-reparatii-auto-masini.cshtml");
        }
    }
}