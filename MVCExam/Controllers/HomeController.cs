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
            return View(_employee.GetAllEmployees());
        }
    }
}