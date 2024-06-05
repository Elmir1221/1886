using Microsoft.AspNetCore.Mvc;

namespace home_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        { 
            return View();
        }
    }
}