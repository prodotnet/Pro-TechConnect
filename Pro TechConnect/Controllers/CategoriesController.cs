using Microsoft.AspNetCore.Mvc;
using Pro_TechConnect.Data;

namespace Pro_TechConnect.Controllers
{
    public class CategoriesController : Controller
    {


        private readonly ProTechConnectDbContext _context;

        public CategoriesController(ProTechConnectDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            // Fetch categories from DbContext
            var categories = _context.Categories.ToList();
            // Pass the list of categories to the view
            return View(categories);
        }
        

        public IActionResult Details(int id)
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


    }
}
