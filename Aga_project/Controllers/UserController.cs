using Microsoft.AspNetCore.Mvc;

namespace Aga_project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
