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

        public ActionResult AddTask()
        {
            return PartialView("_NewTask");
        }

        public ActionResult Clients()
        {
            return PartialView("_Clients");
        }

        public ActionResult AddClient()
        {
            return PartialView("_NewClient");
        }

        public ActionResult Employees()
        {
            return PartialView("_Employees");
        }

        public ActionResult AddEmployee()
        {
            return PartialView("_NewEmployee");
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