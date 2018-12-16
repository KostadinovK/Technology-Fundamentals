using System;
using System.Collections.Generic;
using System.Linq;

public class Band
{
	public string Name { get; private set; }
	public List<string> Members { get; private set; }
	public int PlayTime { get; set; }

	public Band()
	{
	}

	public Band(string name, int playtime)
	{
		Name = name;
		Members = new List<string>();
		PlayTime = playtime;
	}

	public Band(string name, List<string> members, int playtime)
	{
		Name = name;
		Members = members;
		PlayTime = playtime;
	}
}

public class Program
{
	public static void Main()
	{
		Dictionary<string, Band> bands = new Dictionary<string, Band>();

		string input = Console.ReadLine();
		while (input != "start of concert")
		{

			List<string> args = input.Split("; ").ToList();
			if (args[0] == "Add")
			{
				string bandName = args[1];
				List<string> members = args[2].Split(", ").ToList().Distinct().ToList();
				if (!bands.ContainsKey(bandName))
				{
					Band band = new Band(bandName,members,0);
					bands.Add(bandName,band);
				}
				else
				{
					foreach (var member in members)
					{
						if (!bands[bandName].Members.Contains(member))
						{
							bands[bandName].Members.Add(member);
						}
					}
				}
			}else if (args[0] == "Play")
			{
				string bandName = args[1];
				int playTime = int.Parse(args[2]);

				if (!bands.ContainsKey(bandName))
				{
					bands.Add(bandName,new Band(bandName,playTime));
				}
				else
				{
					bands[bandName].PlayTime += playTime;
				}
			}

			input = Console.ReadLine();
		}

		string enteredBand = Console.ReadLine();

		int totalTime = 0;
		foreach (var kvp in bands)
		{
			totalTime += kvp.Value.PlayTime;
		}

		Console.WriteLine($"Total time: {totalTime}");

		foreach (var kvp in bands.OrderByDescending(x => x.Value.PlayTime).ThenBy(x => x.Key))
		{
			Console.WriteLine($"{kvp.Key} -> {kvp.Value.PlayTime}");
		}

		Console.WriteLine(enteredBand);
		foreach (var member in bands[enteredBand].Members)
		{
			Console.WriteLine("=> " + member);
		}
	}
}
