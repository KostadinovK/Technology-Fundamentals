using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

		int maxWagonCapacity = int.Parse(Console.ReadLine());

		string line = Console.ReadLine();
		while (line != "end")
		{
			List<string> words = line.Split().ToList();

			if (words[0] == "Add")
			{
				wagons.Add(int.Parse(words[1]));
			}
			else
			{
				for (int i = 0; i < wagons.Count; i++)
				{
					if (maxWagonCapacity - wagons[i] >= int.Parse(words[0]))
					{
						wagons[i] += int.Parse(words[0]);
						break;
					}
				}
			}

			line = Console.ReadLine();
		}

		Console.WriteLine(string.Join(" ",wagons));
	}
}
