using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeisterMask.Data;
using Task = TeisterMask.Models.Task;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
		[HttpGet]
        public IActionResult Index()
        {
	        using (TeisterMaskDbContext db = new TeisterMaskDbContext())
	        {
		        List<Task> tasks = db.Tasks.ToList();

		        return View(tasks);
			} 
        }

		[HttpGet]
	    public IActionResult Create()
		{
			return View();
		}

	    [HttpPost]
	    public IActionResult Create(Task task)
	    {
		    if (string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Status))
		    {
			    return RedirectToAction("Index");
		    }
			using(TeisterMaskDbContext db = new TeisterMaskDbContext())
			{
				db.Tasks.Add(task);
				db.SaveChanges();
			}
		    return RedirectToAction("Index");
	    }

	    [HttpGet]
	    public IActionResult Edit(int id)
	    {
		    using (TeisterMaskDbContext db = new TeisterMaskDbContext())
		    {
			    List<Task> tasks = db.Tasks.ToList();

			    Task task = tasks.Find(x => x.Id == id); 
			    return View(task);
			}

	    }

	    [HttpPost]
	    public IActionResult Edit(Task task)
	    {
		    if (string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Status) || !ModelState.IsValid)
		    {
			    return RedirectToAction("Index");
		    }

		    using (TeisterMaskDbContext db = new TeisterMaskDbContext())
		    {
			    Task taskToEdit = db.Tasks.FirstOrDefault(x => x.Id == task.Id);
			    if (taskToEdit == null)
			    { 
				    RedirectToAction("Index");
			    }
				taskToEdit.Title = task.Title;
			    taskToEdit.Status = task.Status;
			    db.SaveChanges();
			    return RedirectToAction("Index");
		    }
	    }

	    [HttpGet]
	    public IActionResult Delete(int id)
	    {
		    using (TeisterMaskDbContext db = new TeisterMaskDbContext())
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
	    public IActionResult Delete(Task task)
	    {
		    using (TeisterMaskDbContext db = new TeisterMaskDbContext())
		    {
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