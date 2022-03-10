using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UpAndRunning1.Data;
using UpAndRunning1.Models;

namespace UpAndRunning1.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }

        //Get - Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
