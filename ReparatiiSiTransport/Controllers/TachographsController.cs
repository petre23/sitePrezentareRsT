using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class TachographsController : Controller
    {
        // GET: Tachographs
        public ActionResult Tahografe_Inteligente_Craiova()
        {
            return View("~/Views/Tachographs/Tahografe-Inteligente-Craiova.cshtml");
        }
    }
}