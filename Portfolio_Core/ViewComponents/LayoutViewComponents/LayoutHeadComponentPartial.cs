using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents.LayoutViewComponents
{
	public class LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
