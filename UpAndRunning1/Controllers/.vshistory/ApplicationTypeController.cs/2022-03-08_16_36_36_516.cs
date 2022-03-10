using Microsoft.AspNetCore.Mvc;

namespace UpAndRunning1.Controllers
{
    public class ApplicationTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
