using Microsoft.AspNetCore.Mvc;

namespace STUDENT_MVC_PROJECT.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
    }
}
