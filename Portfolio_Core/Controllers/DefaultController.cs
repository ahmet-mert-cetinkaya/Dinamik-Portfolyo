using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
