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

		for (int i = 1; i < n; i++)
		{
			if (IsTopNum(i))
			{
				Console.WriteLine(i);
			}
		}
	}

	private static bool IsTopNum(int i)
	{
		int sum = 0;
		int temp = i;
		int oddsDigits = 0;
		while (temp > 1)
		{
			int digit = temp % 10;
			if (digit % 2 != 0)
			{
				oddsDigits++;
			}

			sum += digit;
			temp /= 10;
		}

		sum += temp;
		if (sum % 8 == 0 && oddsDigits > 0)
		{
			return true;
		}

		return false;



	}
}
