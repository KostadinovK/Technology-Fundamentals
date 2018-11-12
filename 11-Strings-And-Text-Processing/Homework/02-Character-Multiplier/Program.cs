using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<string> input = Console.ReadLine().Split().ToList();
		string str1 = input[0];
		string str2 = input[1];

		int result = MultiplyStrings(str1,str2);
		Console.WriteLine(result);
	}

	private static int MultiplyStrings(string str1, string str2)
	{
		int sum = 0;
		int minLenght = Math.Min(str1.Length, str2.Length);
		int index = 0;
		for (int i = 0;i < minLenght;i++)
		{
			sum += str1[i] * str2[i];
			index++;
		}

		if (str1.Length > str2.Length)
		{
			for (int j = index; j < str1.Length;j++)
			{
				sum += str1[j];
			}
		}else if (str2.Length > str1.Length)
		{
			for (int j = index; j < str2.Length; j++)
			{
				sum += str2[j];
			}
		}

		return sum;
	}
}
