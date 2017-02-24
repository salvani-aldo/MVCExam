using System.Web.Mvc;

namespace MVCExam.Controllers
{
    public class HomeController : Controller
    {
        //private EmployeeInformationEntities db = new EmployeeInformationEntities();

        // GET: Home
        public ActionResult Index()
        {
            //return View(db.EmployeeMasters.ToList());
            return View();
        }
    }
}