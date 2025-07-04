﻿using Microsoft.AspNetCore.Mvc;
using Portfolio_Core.DataAccessLayer.Context;
using Portfolio_Core.DataAccessLayer.Entities;

namespace Portfolio_Core.Controllers
{
	public class ToDoListController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult Index()
		{
			var value = context.ToDoLists.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateToDoList() 
		{
			return View();
		}
		[HttpPost] 
		public IActionResult CreateToDoList(ToDoList toDoList) 
		{
			toDoList.Status = false;
			context.ToDoLists.Add(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult DeleteToDoList(int id)
		{
			var value= context.ToDoLists.Find(id);
			context.ToDoLists.Remove(value);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateToDoList(int id)
		{
			var value = context.ToDoLists.Find(id);
			return View();
		}
		[HttpPost]
		public IActionResult UpdateToDoList(ToDoList toDoList)
		{
			context.ToDoLists.Update(toDoList);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ChangeToDoListStatusToTrue(int id)
		{
			var value=context.ToDoLists.Find(id);
			value.Status = true;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult ChangeToDoListStatusToFalse(int id)
		{
			var value = context.ToDoLists.Find(id);
			value.Status = false;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
