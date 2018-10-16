using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		double x1 = double.Parse(Console.ReadLine());
		double y1 = double.Parse(Console.ReadLine());

		double x2 = double.Parse(Console.ReadLine());
		double y2 = double.Parse(Console.ReadLine());

		PrintCenterPoint(x1,y1,x2,y2);
	}

	private static void PrintCenterPoint(double x1, double y1, double x2, double y2)
	{
		
		if (Math.Sqrt(x1*x1 + y1*y1) > Math.Sqrt(x2*x2 + y2*y2))
		{
			Console.WriteLine($"({x2}, {y2})");
		}else if (Math.Sqrt(x1 * x1 + y1 * y1) < Math.Sqrt(x2 * x2 + y2 * y2))
		{
			Console.WriteLine($"({x1}, {y1})");
		}
		else
		{
			Console.WriteLine($"({x1}, {y1})");
		}
	}
}
