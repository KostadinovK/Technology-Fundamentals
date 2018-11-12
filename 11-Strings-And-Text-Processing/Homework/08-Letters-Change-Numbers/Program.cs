using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<string> input = Console.ReadLine().Split(new char[]{' ','\t'},StringSplitOptions.RemoveEmptyEntries).ToList();

		double totalSum = 0;
		for (int i = 0;i < input.Count;i++)
		{
			char frontLetter = input[i][0];
			char backLetter = input[i][input[i].Length - 1];
			double number = GetNumber(input[i]);

			if (frontLetter >= 'A' && frontLetter <= 'Z')
			{
				number /= frontLetter - 'A' + 1;
			}
			else if(frontLetter >= 'a' && frontLetter <= 'z')
			{
				number *= frontLetter - 'a' + 1;
			}

			if (backLetter >= 'A' && backLetter <= 'Z')
			{
				number -= backLetter - 'A' + 1;
			}
			else if(backLetter >= 'a' && backLetter <= 'z')
			{
				number += backLetter - 'a' + 1;
			}

			totalSum += number;

		}

		Console.WriteLine($"{totalSum:f2}");
	}

	private static double GetNumber(string str)
	{
		double res = 0;
		string numStr = "";
		for (int i = 1; i < str.Length-1;i++)
		{
			numStr += str[i];
		}

		res = double.Parse(numStr);
		return res;
	}
}
