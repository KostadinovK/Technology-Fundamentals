using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string validLine = @">>(?<name>[A-Za-z]+)<<(?<price>[0-9.]+)!(?<quantity>\d+)\b";
		Regex validLineRegex = new Regex(validLine);
		string line = Console.ReadLine();
		StringBuilder result = new StringBuilder();
		result.Append("Bought furniture:\n");
		decimal totalMoney = 0;
		while (line != "Purchase")
		{
			Match match = validLineRegex.Match(line);
			if (match.Success)
			{
				string name = match.Groups["name"].Value;
				decimal price = decimal.Parse(match.Groups["price"].Value);
				int quantity = int.Parse(match.Groups["quantity"].Value);

				result.Append(name + '\n');
				totalMoney += price * quantity;
			}

			line = Console.ReadLine();
		}

		Console.Write(result);
		Console.WriteLine($"Total money spend: {totalMoney:f2}");
	}
}
