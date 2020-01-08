using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class HeatersController : Controller
    {
        // GET: Heaters
        public ActionResult Incalzitoare_Webastro_Eberspacher()
        {
            return View("~/Views/Heaters/Incalzitoare-Webastro-Eberspacher.cshtml");
        }
    }
}