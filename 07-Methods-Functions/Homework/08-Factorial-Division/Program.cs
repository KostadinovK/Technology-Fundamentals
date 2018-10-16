using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		long num1 = long.Parse(Console.ReadLine());
		long num2 = long.Parse(Console.ReadLine());

		long fact1 = CalculateFactorial(num1);
		long fact2 = CalculateFactorial(num2);

		double res = (double)fact1 / fact2;
		Console.WriteLine($"{res:f2}");
	}

	private static long CalculateFactorial(long num)
	{
		long fac = 1;
		long num2 = num;
		while (num2 > 1)
		{
			fac *= num2;
			num2--;
		}

		return fac;
	}
}
