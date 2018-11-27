using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeisterMask.Models
{
	public class Task
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Status { get; set; }

		public Task(){}

		public Task(string title, string status)
		{
			Title = title;
			Status = status;
		}
	}
}
