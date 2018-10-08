using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		int[] arr1 = new int[n];
		int[] arr2 = new int[n];

		for (int i = 1; i <= n; i++)
		{
			var pair = Console.ReadLine().Split().Select(int.Parse).ToArray();
			if (i % 2 != 0)
			{
				arr1[i-1] = pair[0];
				arr2[i-1] = pair[1];
			}
			else
			{
				arr1[i-1] = pair[1];
				arr2[i-1] = pair[0];
			}
		}

		Console.WriteLine(string.Join(" ", arr1));
		Console.WriteLine(string.Join(" ", arr2));
	}
}
