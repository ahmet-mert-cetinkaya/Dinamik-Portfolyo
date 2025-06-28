using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents.LayoutViewComponents
{
	public class LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
