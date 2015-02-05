using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminar.Controllers
{
    public class SeminarController : Controller
    {
        // GET: Seminar
        public ActionResult Windows8Camp()
        {
            return View();
        }

        public ActionResult LocationBased()
        {
            return View();
        }

        public ActionResult Dump() 
        {
            return View();
        }

        public ActionResult Asean()
        {
            return View();
        }
    }
}