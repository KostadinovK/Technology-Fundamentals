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

		int vowels = CountVowels(word);

		Console.WriteLine(vowels);
	}

	private static int CountVowels(string word)
	{
		word = word.ToLower();
		List<char> vowels = new List<char>{ 'a','e','i', 'o','u', 'y'};
		int vowelsCount = 0;
		for (int i = 0;i < word.Length;i++) {
			if (vowels.Contains(word[i]))
			{
				vowelsCount++;
			}
		}

		return vowelsCount;
	}
}
