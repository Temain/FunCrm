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
            ViewBag.Title = "Заказы";
            return View();
        }

        public ActionResult Tasks()
        {
            ViewBag.Title = "Заказы";
            return PartialView("_Tasks");
        }

        public ActionResult Clients()
        {
            ViewBag.Title = "Клиенты";
            return PartialView("_Clients");
        }

        public ActionResult Employees()
        {
            ViewBag.Title = "Сотрудники";
            return PartialView("_Employees");
        }

        public ActionResult Analize()
        {
            ViewBag.Title = "Анализ";
            return PartialView("_Analize");
        }

        public ActionResult Reports()
        {
            ViewBag.Title = "Отчеты";
            return PartialView("_Reports");
        }
    }
}