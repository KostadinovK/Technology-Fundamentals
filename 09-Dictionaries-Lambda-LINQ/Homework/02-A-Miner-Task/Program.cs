using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary< string, int> orbs = new Dictionary<string, int>();

		string orb = Console.ReadLine();
		int quantity = int.Parse(Console.ReadLine());
	
		while (orb != "stop")
		{
			if (!orbs.ContainsKey(orb))
			{
				orbs[orb] = 0;
			}

			orbs[orb] += quantity;
			orb = Console.ReadLine();
			if (orb == "stop") break;
			quantity = int.Parse(Console.ReadLine());
		}

		foreach (var kvp in orbs)
		{
			Console.WriteLine(kvp.Key + " -> " + kvp.Value);
		}

	}
}
