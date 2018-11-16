using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string regex = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

		string input = Console.ReadLine();

		MatchCollection matchedNums = Regex.Matches(input, regex);

		List<string> res = matchedNums.Select(x => x.Value.Trim()).ToList();

		Console.WriteLine(string.Join(" ",res));
	}
}
