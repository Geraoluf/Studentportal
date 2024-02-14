using Microsoft.AspNetCore.Mvc;

namespace Studentportal.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
