using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
	{
	public static void Main(string[] args)
	{
		string[] days = new string[]{"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday"};

		int day = int.Parse(Console.ReadLine());
		if (day < 8 && day > 0)
		{
			Console.WriteLine(days[day-1]);
		}
		else
		{
			Console.WriteLine("Invalid day!");
		}
	}
}
