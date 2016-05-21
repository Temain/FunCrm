using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FunCrm.Web.Controllers
{
    public class ReportController : Controller
    {
        [HttpGet]
        public ActionResult ByIncome()
        {
            var fileContents = new byte[1];

            return new FileContentResult(fileContents, "application/vnd.ms-excel") { FileDownloadName = "Данные о прибыли.xls" };
        }

        [HttpGet]
        public ActionResult ByWorkPerformed()
        {
            var fileContents = new byte[1];

            return new FileContentResult(fileContents, "application/vnd.ms-excel") { FileDownloadName = "Данные о выполненных заказах.xls" };
        }
    }
}