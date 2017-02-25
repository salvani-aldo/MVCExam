using BL;
using System.Web.Mvc;

namespace MVCExam.Controllers
{
    public class HomeController : Controller
    {
        Employee _employee = new Employee();

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.PageTitle = "Employee List Page";
            return View(_employee.GetAllEmployees());
        }

        public ActionResult Echo()
        {
            return View();
        }
    }
}