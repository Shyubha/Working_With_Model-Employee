using Microsoft.AspNetCore.Mvc;

namespace Working_With_Model_Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
