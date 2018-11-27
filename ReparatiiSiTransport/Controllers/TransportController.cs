using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class TransportController : Controller
    {
        // GET: Transport
        public ActionResult Transport_marfa_intern_international()
        {
            return View("~/Views/Transport/Transport-marfa-intern-international.cshtml");
        }
    }
}