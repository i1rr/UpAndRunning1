using Microsoft.AspNetCore.Mvc;

namespace UpAndRunning1.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
