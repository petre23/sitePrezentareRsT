using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReparatiiSiTransport.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult Acte_auto_inmatriculare_impozite_taxe()
        {
            return View("~/Views/Documents/Acte-auto-inmatriculare-impozite-taxe.cshtml");
        }
    }
}