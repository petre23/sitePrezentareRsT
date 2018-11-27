using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs
        public ActionResult Cariere_sofer_reparatii_craiova()
        {
            return View("~/Views/Jobs/Cariere-sofer-reparatii-craiova.cshtml");
        }
    }
}