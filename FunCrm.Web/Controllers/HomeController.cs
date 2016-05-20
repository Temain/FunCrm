using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunCrm.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tasks()
        {
            return PartialView("_Tasks");
        }

        public ActionResult Employees()
        {
            return PartialView("_Employees");
        }

        public ActionResult Analize()
        {
            return PartialView("_Analize");
        }

        public ActionResult Reports()
        {
            return PartialView("_Reports");
        }
    }
}