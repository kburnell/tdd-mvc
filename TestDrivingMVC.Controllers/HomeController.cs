using System.Web.Mvc;
using TestDrivingMVC.Service.Interfaces;

namespace TestDrivingMVC.Controllers {

    //Consumer of Employe Service
    public class HomeController : Controller {

        private readonly IEmployeeService _employeeService;

        public HomeController(IEmployeeService employeeService) {
            _employeeService = employeeService;
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult DisplaySalary(long id) {
            decimal salary = _employeeService.CalculateSalary(id);
            return View(salary);
        }

    }
}