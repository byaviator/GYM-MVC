using GYM_MVC.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace GYM_MVC.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class DashboardController : Controller
    {

        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }

        public IActionResult Index()
        {
          var program = _context.Programs.ToList();

            return View(program);
        }
    }
}
