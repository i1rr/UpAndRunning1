using Microsoft.AspNetCore.Mvc;

namespace UpAndRunning1.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
