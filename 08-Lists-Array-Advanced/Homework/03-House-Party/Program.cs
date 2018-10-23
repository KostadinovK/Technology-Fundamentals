using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<string> guests = new List<string>();

		int commands = int.Parse(Console.ReadLine());

		for (int i = 0;i < commands;i++)
		{
			string command = Console.ReadLine();
			List<string> args = command.Split().ToList();

			string name = args[0];
			if (args[1] == "is" && args[2] != "not")
			{
				if (guests.Contains(name))
				{
					Console.WriteLine($"{name} is already in the list!");
				}
				else
				{
					guests.Add(name);
				}
			}
			else
			{
				if(guests.Contains(name))
				{
					guests.Remove(name);
				}
				else
				{
					Console.WriteLine($"{name} is not in the list!");
				}
			}
		}

		Console.WriteLine(string.Join("\n",guests));
	}
}
