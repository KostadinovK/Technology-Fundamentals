using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{

		int meters = int.Parse(Console.ReadLine());
		double kilometers = (double)meters / 1000;
		Console.WriteLine($"{kilometers:f2}");

	}
}
