using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents
{
    public class StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
