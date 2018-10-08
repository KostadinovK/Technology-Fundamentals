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
		int n = int.Parse(Console.ReadLine());
		int[] peoplesCountInWagons = new int[n];
		int sum = 0;
		for (int i = 0; i < n; i++)
		{
			int peoples = int.Parse(Console.ReadLine());
			peoplesCountInWagons[i] = peoples;
			sum += peoplesCountInWagons[i];
		}

		Console.WriteLine(string.Join(" ", peoplesCountInWagons));
		Console.WriteLine(sum);
	}
}
