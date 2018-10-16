using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string line = Console.ReadLine();
		while (line != "END")
		{
			int num = int.Parse(line);
			if (IsPalindrome(num))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}

			line = Console.ReadLine();
		}
	}

	private static bool IsPalindrome(int num)
	{
		string line = num.ToString();
		string reversedLine = "";
		for (int i = line.Length - 1; i >= 0;i--)
		{
			reversedLine += line[i];
		}

		if (line == reversedLine)
		{
			return true;
		}

		return false;
	}
}
