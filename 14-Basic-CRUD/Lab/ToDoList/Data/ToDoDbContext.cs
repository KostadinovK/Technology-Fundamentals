using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Task = ToDoList.Models.Task;

namespace ToDoList.Data
{
	public class ToDoDbContext : DbContext
	{
		public DbSet<Task> Tasks { get; set; }

		private const string connectionString = @"Server=.\SQLEXPRESS;Database=ToDoListDb;Integrated Security=True;";

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
