﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

	class Program { 
		static void Main() {
			double grade = double.Parse(Console.ReadLine());
			
			if(grade >= 3.0) {
				Console.WriteLine("Passed!");
			} else {
				Console.WriteLine("Failed!");
			}
		}
	}
