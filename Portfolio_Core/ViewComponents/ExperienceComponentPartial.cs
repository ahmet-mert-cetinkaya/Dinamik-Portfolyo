using Microsoft.AspNetCore.Mvc;
using Portfolio_Core.DataAccessLayer.Context;

namespace Portfolio_Core.ViewComponents
{
    public class ExperienceComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Experiences.ToList();
            return View(values);
        }
    }
}
