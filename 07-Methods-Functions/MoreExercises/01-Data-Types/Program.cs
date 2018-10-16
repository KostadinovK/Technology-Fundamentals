using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string type = Console.ReadLine();
		if (type == "int")
		{
			int num = int.Parse(Console.ReadLine());
			PrintModifiedInput(num);
		}else if (type == "real")
		{
			double num = double.Parse(Console.ReadLine());
			PrintModifiedInput(num);
		}else if (type == "string")
		{
			string s = Console.ReadLine();
			PrintModifiedInput(s);
		}
	}

	private static void PrintModifiedInput(string s)
	{
		Console.WriteLine("$" + s + "$");
	}

	private static void PrintModifiedInput(double num)
	{
		Console.WriteLine($"{num * 1.5:f2}");
	}

	private static void PrintModifiedInput(int num)
	{
		Console.WriteLine(num * 2);
	}
}
