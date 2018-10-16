using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	public static void Main()
	{
		string word = Console.ReadLine();

		PrintMiddleCharacters(word);
	}

	private static void PrintMiddleCharacters(string word)
	{
		if (word.Length % 2 != 0)
		{
			int middle = word.Length / 2;
			Console.WriteLine(word[middle]);
		}
		else
		{
			int middle = word.Length / 2;
			string res = "" + word[middle-1] + word[middle];
			Console.WriteLine(res);
		}
	}
}
