using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents
{
    public class TestimonialComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
