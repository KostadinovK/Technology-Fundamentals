using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int num1 = int.Parse(Console.ReadLine());
		int num2 = int.Parse(Console.ReadLine());
		int num3 = int.Parse(Console.ReadLine());


		int sum = Sum(num1, num2);
		int substraction = Substract(sum, num3);

		Console.WriteLine(substraction);
	}

	private static int Substract(int sum, int num3)
	{
		return sum - num3;
	}

	private static int Sum(int num1, int num2)
	{
		return num1 + num2;
	}
}
