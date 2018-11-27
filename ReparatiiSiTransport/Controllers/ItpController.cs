using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class ItpController : Controller
    {
        // GET: Itp
        public ActionResult Itp_inspectie_tehnica_periodica_craiova()
        {
            return View("~/Views/Itp/Itp-inspectie-tehnica-periodica-craiova.cshtml");
        }
    }
}