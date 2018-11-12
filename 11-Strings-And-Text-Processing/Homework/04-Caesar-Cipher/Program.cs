using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string text = Console.ReadLine();
		StringBuilder sb = new StringBuilder();

		for (int i = 0;i < text.Length;i++)
		{
			int newCharNum = text[i] + 3;
			char newChar = (char)newCharNum;
			sb.Append(newChar);
		}

		Console.WriteLine(sb.ToString());
	}
}
