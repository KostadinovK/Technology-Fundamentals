using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BandRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace BandRegister.Data
{
	public class BandRegisterDbContext : DbContext
	{
		private string connectionString = "Server=DESKTOP-6G80PGL\\SQLEXPRESS;Database=BandsDb;Integrated Security=True";

		public DbSet<Band> Bands { get; private set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
