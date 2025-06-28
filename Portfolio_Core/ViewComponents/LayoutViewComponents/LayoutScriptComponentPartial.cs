using Microsoft.AspNetCore.Mvc;

namespace Portfolio_Core.ViewComponents.LayoutViewComponents
{
	public class LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
