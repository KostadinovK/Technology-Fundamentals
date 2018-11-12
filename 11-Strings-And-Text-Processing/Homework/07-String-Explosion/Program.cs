using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<char> chars = Console.ReadLine().ToCharArray().ToList();

		int strength = 0;

		for (int i = 0; i < chars.Count; i++)
		{
			if (chars[i] == '>')
			{
				strength += int.Parse(chars[i + 1].ToString());
			}
			else
			{
				if (strength > 0)
				{
					chars.RemoveAt(i);
					i--;
					strength--;
				}
			}
		}
		Console.WriteLine(string.Join("", chars));
	}
}
