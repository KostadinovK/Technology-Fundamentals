using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;
using ToDoList.Models;
using Task = ToDoList.Models.Task;

namespace ToDoList.Controllers
{
	public class TaskController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			using (ToDoDbContext db = new ToDoDbContext())
			{
				List<Task> allTasks = db.Tasks.ToList();
				return View(allTasks);
			}
		}
		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(string title, string comments)
		{
			if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
			{
				return RedirectToAction("Index");
			}

			Task task = new Task(title,comments);

			using (ToDoDbContext db = new ToDoDbContext())
			{
				db.Add(task);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			using (ToDoDbContext db = new ToDoDbContext())
			{
				Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
				if (task == null)
				{
					return RedirectToAction("Index");
				}

				return View(task); 
			}
		}

		[HttpPost]
		public IActionResult Edit(Task task)
		{
			if (!ModelState.IsValid)
			{
				RedirectToAction("Index");
			}

			using (ToDoDbContext db = new ToDoDbContext())
			{
				Task taskToEdit = db.Tasks.FirstOrDefault(x => x.Id == task.Id);
				taskToEdit.Title = task.Title;
				taskToEdit.Comments = task.Comments;
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			using (ToDoDbContext db = new ToDoDbContext())
			{
				Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
				if (task == null)
				{
					RedirectToAction("Index");
				}

				return View(task);
			}
		}

		[HttpPost]
		public IActionResult Delete(int id)
		{
			using (ToDoDbContext db = new ToDoDbContext())
			{
				Task task = db.Tasks.FirstOrDefault(x => x.Id == id);
				if (task == null)
				{
					RedirectToAction("Index");
				}

				db.Tasks.Remove(task);
				db.SaveChanges();
			}

			return RedirectToAction("Index");
		}
	}
}
