using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{

	public static void Main()
	{
		string name = Console.ReadLine();
		int age = int.Parse(Console.ReadLine());
		double grade = double.Parse(Console.ReadLine());

		Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
	}
}
