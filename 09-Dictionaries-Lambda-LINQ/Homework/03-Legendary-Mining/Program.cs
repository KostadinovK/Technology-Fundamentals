using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary<string,string> resourceToItem = new Dictionary<string, string>
		{
			{"motes","Dragonwrath"},
			{"shards","Shadowmourne"},
			{"fragments","Valanyr"}
		};

		Dictionary<string, int> legendaryResources = new Dictionary<string, int>
		{
			{"motes",0},
			{"shards",0},
			{"fragments",0}
		};
		Dictionary<string,int> junkResources = new Dictionary<string, int>();

		List<string> input = Console.ReadLine().Split().ToList().Select(x => x.ToLower()).ToList();
		while (true)
		{
			for (int i = 0; i < input.Count - 1; i += 2)
			{
				int quantity = int.Parse(input[i]);
				string resourceName = input[i + 1];

				if (resourceName == "motes" || resourceName == "shards" || resourceName == "fragments")
				{

					legendaryResources[resourceName] += quantity;
					if (legendaryResources[resourceName] >= 250)
					{
						legendaryResources[resourceName] -= 250;
						Console.WriteLine($"{resourceToItem[resourceName]} obtained!");
						foreach (var kvp in legendaryResources.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
						{
							Console.WriteLine(kvp.Key + ": " + kvp.Value);
						}

						foreach (var kvp in junkResources.OrderBy(x => x.Key))
						{
							Console.WriteLine(kvp.Key + ": " + kvp.Value);
						}

						return;
					}
				}
				else
				{
					if (!junkResources.ContainsKey(resourceName))
					{
						junkResources[resourceName] = 0;
					}

					junkResources[resourceName] += quantity;
				}
			}
			input = Console.ReadLine().Split().ToList().Select(x => x.ToLower()).ToList();
		}

		

	}
}
