using System.Collections.Generic;
using System.Linq;
using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
	        using (var db = new BandRegisterDbContext())
	        {
				List<Band> tasks = db.Bands.ToList();

		        return View(tasks);
			}
        }

        [HttpGet]
        public IActionResult Create()
        {
	        return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {

			if (string.IsNullOrEmpty(band.Name) || string.IsNullOrEmpty(band.Members))
	        {
		        return RedirectToAction("Index");
	        }
	        using (BandRegisterDbContext db = new BandRegisterDbContext())
	        {
		        db.Bands.Add(band);
		        db.SaveChanges();
	        }
	        return RedirectToAction("Index");
		}

        [HttpGet]
        public IActionResult Edit(int id)
        {
			using (BandRegisterDbContext db = new BandRegisterDbContext())
			{
				List<Band> tasks = db.Bands.ToList();

				Band task = tasks.Find(x => x.Id == id);
				return View(task);
			}
		}

        [HttpPost]
        public IActionResult Edit(Band band)
        {
	        using (var db = new BandRegisterDbContext())
	        {
		        Band toEdit = db.Bands.FirstOrDefault(x => x.Id == band.Id);
				if (toEdit == null)
				{
					RedirectToAction("Index");
				}

				toEdit.Genre = band.Genre;
		        toEdit.Honorarium = band.Honorarium;
		        toEdit.Members = band.Members;
		        toEdit.Name = band.Name;

		        db.SaveChanges();
		        return RedirectToAction("Index");
	        }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
			using (BandRegisterDbContext db = new BandRegisterDbContext())
			{
				Band task = db.Bands.FirstOrDefault(x => x.Id == id);
				if (task == null)
				{
					RedirectToAction("Index");
				}

				return View(task);
			}
		}

        [HttpPost]
        public IActionResult Delete(Band band)
        {
			using (BandRegisterDbContext db = new BandRegisterDbContext())
	        {
		        if (band == null)
		        {
			        RedirectToAction("Index");
		        }
		        db.Bands.Remove(band);
		        db.SaveChanges();
	        }

	        return RedirectToAction("Index");
		}
    }
}