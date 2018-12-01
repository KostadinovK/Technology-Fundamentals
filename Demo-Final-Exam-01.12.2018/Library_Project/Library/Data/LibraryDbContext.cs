using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Data
{
	public class LibraryDbContext : DbContext
	{
		private const string connectionString = "Server=DESKTOP-K2PIPED\\SQLEXPRESS;Database=BooksDb;Integrated Security=True";

		public DbSet<Book> Books { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
