using Microsoft.AspNetCore.Mvc;

namespace RockSetter.Controllers
{
    public class Rock1Controller : Controller
    {
        // GET: /Rock1/
        public IActionResult Index()
        {
            return View();
        }
    }
}