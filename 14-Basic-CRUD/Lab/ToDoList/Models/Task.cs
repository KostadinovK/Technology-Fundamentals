using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
	public class Task
	{
		public int Id { get; set; }
		[Required] public string Title { get; set; }
		[Required] public string Comments { get; set; }

		public Task(string title, string comments)
		{
			this.Comments = comments;
			this.Title = title;
		}


	}
}
