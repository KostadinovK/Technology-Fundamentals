using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary<string,string> registeredCars = new Dictionary<string, string>();
		int n = int.Parse(Console.ReadLine());

		for (int i = 0;i < n;i++)
		{
			List<string> args = Console.ReadLine().Split().ToList();
			string command = args[0];
			string name = args[1];

			if (command == "register")
			{
				string plateNumber = args[2];
				if (registeredCars.ContainsKey(name))
				{
					Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
				}
				else
				{
					registeredCars.Add(name,plateNumber);
					Console.WriteLine($"{name} registered {plateNumber} successfully");
				}
			}
			else
			{
				if (registeredCars.ContainsKey(name))
				{
					registeredCars.Remove(name);
					Console.WriteLine($"{name} unregistered successfully");
				}
				else
				{
					Console.WriteLine($"ERROR: user {name} not found");
				}
			}


		}

		foreach (var kvp in registeredCars)
		{
			Console.WriteLine(kvp.Key + " => " + kvp.Value);
		}
	}
}
