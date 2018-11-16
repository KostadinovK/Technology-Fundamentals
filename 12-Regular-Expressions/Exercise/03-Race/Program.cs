using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		Dictionary<string,int> runnersWithDistances = new Dictionary<string, int>();

		List<string> runners = Console.ReadLine().Split(", ").ToList();
		string regex = @"[A-Za-z0-9]+";
		Regex validLine =  new Regex(regex);
		string line = Console.ReadLine();
		while (line != "end of race")
		{
			MatchCollection matched = validLine.Matches(line);
			if (matched.Count > 0)
			{
				StringBuilder sb = new StringBuilder();
				foreach (var m in matched)
				{
					sb.Append(m);
				}

				string clearLine = sb.ToString();
				string name = "";
				int distance = 0;
				parseLine(clearLine, ref name, ref distance);

				if (runnersWithDistances.ContainsKey(name))
				{
					runnersWithDistances[name] += distance;
				}
				else if(!runnersWithDistances.ContainsKey(name) && runners.Contains(name))
				{
					runnersWithDistances.Add(name,distance);
				}
			}

			line = Console.ReadLine();
		}

		int position = 1;
		foreach (var pair in runnersWithDistances.OrderByDescending(x => x.Value))
		{
			if (position == 1)
			{
				Console.WriteLine($"1st place: {pair.Key}");
			}else if (position == 2)
			{
				Console.WriteLine($"2nd place: {pair.Key}");
			}
			else
			{
				Console.WriteLine($"3rd place: {pair.Key}");
			}

			position++;
			if (position > 3)
			{
				break;
			}
		}
	}

	private static void parseLine(string clearLine, ref string name, ref int distance)
	{
		for (int i = 0;i < clearLine.Length;i++)
		{
			if (char.IsDigit(clearLine[i]))
			{
				distance += clearLine[i] - '0';
			}
			else
			{
				name += clearLine[i];
			}
		}
	}
}
