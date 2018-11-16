using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

		string names = Console.ReadLine();

		MatchCollection matchedNames = Regex.Matches(names, regex);

		foreach (Match m in matchedNames)
		{
			Console.Write(m.Value + " ");
		}

		Console.WriteLine();
	}
}
