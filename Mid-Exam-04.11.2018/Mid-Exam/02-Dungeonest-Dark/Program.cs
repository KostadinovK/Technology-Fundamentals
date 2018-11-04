using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int health = 100;
		int coins = 0;

		List<string> rooms = Console.ReadLine().Split('|').ToList();

		bool isKilled = false;
		for (int i = 0;i < rooms.Count;i++)
		{
			List<string> tokens = rooms[i].Split().ToList();
			if (tokens[0] == "potion")
			{
				int pointsToHeal = int.Parse(tokens[1]);
				health += pointsToHeal;
				if (health > 100)
				{
					int overhealth = pointsToHeal - (health - 100);
					health = 100;
					Console.WriteLine($"You healed for {overhealth} hp.");
				
				}
				else
				{
					Console.WriteLine($"You healed for {pointsToHeal} hp.");
				}

				Console.WriteLine($"Current health: {health} hp.");
			}else if (tokens[0] == "chest")
			{
				int foundedCoins = int.Parse(tokens[1]);
				coins += foundedCoins;
				Console.WriteLine($"You found {foundedCoins} coins.");
			}
			else
			{
				string monster = tokens[0];
				int attackPower = int.Parse(tokens[1]);

				health -= attackPower;
				if (health > 0)
				{
					Console.WriteLine($"You slayed {monster}.");
				}
				else
				{
					Console.WriteLine($"You died! Killed by {monster}.");
					Console.WriteLine($"Best room: {i + 1}");
					isKilled = true;
					break;
				}
			}


		}

		if (!isKilled)
		{
			Console.WriteLine("You've made it!");
			Console.WriteLine($"Coins: {coins}");
			Console.WriteLine($"Health: {health}");
		}
	}
}
