using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UpAndRunning1.Data;
using UpAndRunning1.Models;

namespace UpAndRunning1.Controllers
{
    public class ApplicationTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ApplicationTypeController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        public IActionResult Index()
        {
            IEnumerable<ApplicationType> objList = _db.ApplicationType;
            return View();
        }
    }
}
