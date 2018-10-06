using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		string[] arr1 = Console.ReadLine().Split().ToArray();
		string[] arr2 = Console.ReadLine().Split().ToArray();

		for (int i = 0;i < arr1.Length;i++)
		{
			if (arr1[i] != arr2[i])
			{
				Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
				return;
			}
		}

		int sum = 0;
		for (int i = 0;i < arr1.Length;i++)
		{
			sum += int.Parse(arr1[i]);
		}

		Console.WriteLine($"Arrays are identical. Sum: {sum}");
	}
}
