using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{

		int n = int.Parse(Console.ReadLine());
		int m = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());

		double nDividedByTwo = n / 2.0;

		int pokesCount = 0;
		while (n >= m)
		{
			if (n == nDividedByTwo)
			{
				if (y != 0)
				{
					n = n / y;
				}
				if (n >= m)
				{
					n = n - m;
					pokesCount++;
				}
			}
			else
			{
				n = n - m;
				pokesCount++;
			}

		}
		Console.WriteLine(n);
		Console.WriteLine(pokesCount);

	}
}
