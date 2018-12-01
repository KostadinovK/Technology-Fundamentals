using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
	    public int Id { get; set; }

	    [Required] public string Title { get; set; }
	    [Required] public string Author { get; set; }
	    [Required] [Range(1,Double.MaxValue)] public double Price { get; set; }

	    public Book()
	    {
	    }

	    public Book(string title, string author, double price)
	    {
		    this.Title = title;
		    this.Author = author;
		    this.Price = price;
	    }

		public bool IsValidModel()
		{
			if (string.IsNullOrEmpty(this.Title) || string.IsNullOrEmpty(this.Author) || double.IsNaN(this.Price) ||
			    this.Price < 1)
			{
				return false;
			}

			return true;
		}
    }
}
