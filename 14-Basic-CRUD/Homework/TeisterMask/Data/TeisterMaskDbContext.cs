using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task = TeisterMask.Models.Task;

namespace TeisterMask.Data
{
	public class TeisterMaskDbContext : DbContext
	{
		public DbSet<Task> Tasks { get; set; }

		private const string connectionString = "Server=DESKTOP-6G80PGL\\SQLEXPRESS;Database=TasksDb;Integrated Security=True"; 

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
