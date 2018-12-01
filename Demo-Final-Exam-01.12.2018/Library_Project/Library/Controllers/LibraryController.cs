using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
	        using (LibraryDbContext db = new LibraryDbContext())
	        {
		        List<Book> books = db.Books.ToList();
		        return View(books);
			}
            
        }

        [HttpGet]
        public IActionResult Create()
        {
	        return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
	        if (book.IsValidModel())
	        {
		        using (LibraryDbContext db = new LibraryDbContext())
		        {
			        db.Add(book);
			        db.SaveChanges();
		        }
	        }

	        return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
	        using (LibraryDbContext db = new LibraryDbContext())
	        {
		        Book book = db.Books.FirstOrDefault(x => x.Id == id);
		        return View(book);
			}
	        
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
	        if (book.IsValidModel())
	        {
		        using (LibraryDbContext db = new LibraryDbContext())
		        {
			        Book bookToEdit = db.Books.FirstOrDefault(x => x.Id == book.Id);
			        if (bookToEdit == null)
			        {
				        return RedirectToAction("Index");
			        }

			        bookToEdit.Author = book.Author;
			        bookToEdit.Price = book.Price;
			        bookToEdit.Title = book.Title;
			        db.SaveChanges();
		        }
	        }

	        return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
	        using (LibraryDbContext db = new LibraryDbContext())
	        {
		        Book book = db.Books.FirstOrDefault(x => x.Id == id);

		        return View(book);
	        }
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
	        if (book != null)
	        {
		        using (LibraryDbContext db = new LibraryDbContext())
		        {
			        Book bookToDelete = db.Books.FirstOrDefault(x => x.Id == book.Id);
			        if (bookToDelete == null)
			        {
				        return RedirectToAction("Index");
			        }

			        db.Books.Remove(bookToDelete);
			        db.SaveChanges();
		        }
			}

            return RedirectToAction("Index");
        }
    }
}