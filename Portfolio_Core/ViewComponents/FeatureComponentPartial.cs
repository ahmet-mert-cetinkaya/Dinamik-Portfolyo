using Microsoft.AspNetCore.Mvc;
using Portfolio_Core.DataAccessLayer.Context;

namespace Portfolio_Core.ViewComponents
{
    public class FeatureComponentPartial : ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
