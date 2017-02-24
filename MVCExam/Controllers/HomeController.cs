using MVCExam.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExam.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeInformationEntities db = new EmployeeInformationEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View(db.EmployeeMasters.ToList());
        }
    }
}