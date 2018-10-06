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
		int[] numbers = new int[n];

		for (int i = 0; i < n; i++)
		{
			int num = int.Parse(Console.ReadLine());
			numbers[i] = num;
		}

		for (int i = n-1; i >= 0; i--)
		{
			Console.Write(numbers[i] + " ");
		}
	}
}
