﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main() {
	
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());
		int num4 = int.Parse(Console.ReadLine());

		long result = (num1 + num2) / num3 * num4;
		Console.WriteLine(result);
	
	}

}
