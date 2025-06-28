using Microsoft.AspNetCore.Mvc;
using Portfolio_Core.DataAccessLayer.Context;

namespace Portfolio_Core.ViewComponents
{
    public class SkillComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Skills.ToList();
            return View(values);
        }
    }
}
