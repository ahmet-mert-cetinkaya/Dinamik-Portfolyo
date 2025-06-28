using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents
{
    public class ContactComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
