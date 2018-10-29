using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string text = Console.ReadLine().Replace(" ","");

		Dictionary<char,int> counter = new Dictionary<char, int>();

		for (int i = 0; i < text.Length; i++)
		{
			if (!counter.ContainsKey(text[i]))
			{
				counter[text[i]] = 0;
			}

			counter[text[i]]++;
		}

		foreach (var kvp in counter)
		{
			Console.WriteLine(kvp.Key + " -> " + kvp.Value);
		}
	}
}
