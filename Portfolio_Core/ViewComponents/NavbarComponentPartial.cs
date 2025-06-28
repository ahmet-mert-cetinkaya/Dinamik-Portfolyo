using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents
{
    public class NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
