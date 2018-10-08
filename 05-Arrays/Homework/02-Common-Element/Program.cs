using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string[] arr1 = Console.ReadLine().Split().ToArray();
		string[] arr2 = Console.ReadLine().Split().ToArray();

		string[] commonWords = new string[arr1.Length];
		int j = 0;
		for (int i = 0;i < arr2.Length;i++)
		{
			if (arr1.Contains(arr2[i]))
			{
				commonWords[j] = arr2[i];
				j++;
			}
		}

		Console.WriteLine(string.Join(" ", commonWords));
	}
}
