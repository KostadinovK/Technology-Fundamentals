using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int a = int.Parse(Console.ReadLine());
		int b = int.Parse(Console.ReadLine());
		int c = int.Parse(Console.ReadLine());

		int max = FindMinNumberFromThree(a,b,c);
		Console.WriteLine(max);
	}

	private static int FindMinNumberFromThree(int a, int b, int c)
	{
		if (a <= b && a <= c)
		{
			return a;
		}else if (b <= a && b <= c)
		{
			return b;
		}else if (c <= a && c <= b)
		{
			return c;
		}

		return -1;
	}
}
