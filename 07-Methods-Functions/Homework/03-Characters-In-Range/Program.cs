using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		char from = char.Parse(Console.ReadLine());
		char to = char.Parse(Console.ReadLine());

		PrintChars(from,to);
	}

	private static void PrintChars(char from, char to)
	{
		if (to >= from)
		{
			for (int i = from + 1; i < to; i++)
			{
				Console.Write((char)i + " ");
			}
		}
		else
		{
			for (int i = to + 1; i < from; i++)
			{
				Console.Write((char)i + " ");
			}
		}


	}
}
