using Microsoft.AspNetCore.Mvc;

namespace HW13_MVC.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
