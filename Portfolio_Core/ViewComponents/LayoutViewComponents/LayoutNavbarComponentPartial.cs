using Microsoft.AspNetCore.Mvc;
using Portfolio_Core.DataAccessLayer.Context;

namespace Portfolio_Core.ViewComponents.LayoutViewComponents
{
	public class LayoutNavbarComponentPartial : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoLists.Where(x=> x.Status==false).Count();
			var value = context.ToDoLists.Where(x => x.Status == false).ToList();
			return View();
		}
	}
}
