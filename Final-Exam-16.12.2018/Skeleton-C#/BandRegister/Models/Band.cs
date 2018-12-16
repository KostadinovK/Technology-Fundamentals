﻿using System.ComponentModel.DataAnnotations;

namespace BandRegister.Models
{
    public class Band
    {
	    public int Id { get; set; }

		[Required]
		public string Name { get;  set; }

	    [Required] 
	    public string Members { get; set; }

	    [Required]
	    public double Honorarium { get; set; }

	    [Required]
	    public string Genre { get; set; }

	    public Band()
	    {
	    }

	    public Band(string name, string members, double honorarium, string genre)
	    {
		    this.Name = name;
		    this.Members = members;
		    this.Honorarium = honorarium;
		    this.Genre = genre;
	    }
    }
}