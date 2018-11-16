using System;
using System.Text.RegularExpressions;

public class Program
{
	static void Main()
	{
		string regex = @"(?<![A-Z0-9a-z._-])[a-z0-9A-Z][a-z0-9._-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-]+([a-z.])*\b";

		string text = Console.ReadLine();

		MatchCollection emails = Regex.Matches(text, regex);

		foreach (var email in emails)
		{
			Console.WriteLine(email);
		}
	}
}
