using Microsoft.AspNetCore.Mvc;

namespace HW13_MVC.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
