using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary<string,string> nameToSide = new Dictionary<string, string>();

		string line = Console.ReadLine();

		while (line != "Lumpawaroo")
		{
			if (line.Contains(" | "))
			{
				List<string> tokens = line.Split(new string[]{" | "}, StringSplitOptions.None).ToList();
				string side = tokens[0];
				string username = tokens[1];

				if (!nameToSide.ContainsKey(username))
				{
					nameToSide[username] = side;
				}

				
			}else if (line.Contains(" -> "))
			{
				List<string> tokens = line.Split(new string[] { " -> " }, StringSplitOptions.None).ToList();
				string side = tokens[1];
				string username = tokens[0];

				nameToSide[username] = side;

				Console.WriteLine($"{username} joins the {side} side!");
			}

			line = Console.ReadLine();
		}

		var groupedDict = nameToSide.GroupBy(x => x.Value)
			.ToDictionary(x => x.Key, x => x.ToDictionary(y => y.Key, y => y.Value));

		foreach (var kvp in groupedDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
		{
			Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
			foreach (var nameSidePair in kvp.Value.OrderBy(x => x.Key))
			{
				Console.WriteLine($"! {nameSidePair.Key}");
			}
		}
	}
}
