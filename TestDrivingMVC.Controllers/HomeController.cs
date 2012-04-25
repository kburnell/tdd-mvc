using System.Web.Mvc;
using TestDrivingMVC.Service;

namespace TestDrivingMVC.Controllers {

    //Consumer of Employe Service
    public class HomeController : Controller {

        public ActionResult DisplaySalary(long employeeId) {
            EmployeeService employeeService = new EmployeeService();
            decimal salary = employeeService.CalculateSalary(employeeId);
            return View(salary);
        }

    }
}