using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string regex = @"\+359([- ])2\1\d{3}\1\d{4}\b";
		
		string numbers = Console.ReadLine();

		MatchCollection matchedNumbers = Regex.Matches(numbers, regex);

		List<string> result = matchedNumbers.Cast<Match>().Select(x => x.Value.Trim()).ToList();

		Console.WriteLine(string.Join(", ",result));
	}
}
