using Microsoft.AspNetCore.Mvc;
using GYM_MVC.Services;
using GYM_MVC.Models;

namespace GYM_MVC.Controllers
{
    public class HomeController : Controller
    {
        public readonly ProgramModelService _service = new ProgramModelService();

        public IActionResult Index()
        {
            return View( _service.GetAllProgramModels() );
        }
    }
}
