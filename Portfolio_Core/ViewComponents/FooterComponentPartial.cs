using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents
{
    public class FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
