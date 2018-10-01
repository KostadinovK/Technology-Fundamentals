using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main() {
		double r = double.Parse(Console.ReadLine());

		double area = Math.PI * r * r;
		Console.WriteLine($"{area:f12}");
		
		
	}
}
