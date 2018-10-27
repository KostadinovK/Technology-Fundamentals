using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		double energy = 100;
		double coins = 100;

		List<string> workdayThingsToDo = Console.ReadLine().Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
		bool bankrupt = false;
		for (int i = 0;i < workdayThingsToDo.Count;i++)
		{
			List<string> args = workdayThingsToDo[i].Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

			if (args[0] == "rest")
			{
				double energyToAdd = double.Parse(args[1]);
				double oldEnergy = energy;
				energy += energyToAdd;
				if (energy > 100)
				{
					energy = 100;
					Console.WriteLine($"You gained {energy-oldEnergy} energy.");
				}
				else
				{
					Console.WriteLine($"You gained {energyToAdd} energy.");
				}

				Console.WriteLine($"Current energy: {energy}.");
			}else if (args[0] == "order")
			{
				double coinsToEarn = double.Parse(args[1]);
				const int ENERGY_DECREASE = 30;
				const int ENERGY_INCREASE = 50;

				energy -= ENERGY_DECREASE;
				if (energy < 0)
				{
					energy += ENERGY_DECREASE;
					Console.WriteLine("You had to rest!");
					energy += ENERGY_INCREASE;
					if (energy > 100) energy = 100;
				}
				else
				{
					coins += coinsToEarn;
					Console.WriteLine($"You earned {coinsToEarn} coins.");
				}
			}
			else
			{
				string ingredientName = args[0];
				double ingredientPrice = double.Parse(args[1]);

				coins -= ingredientPrice;

				if (coins > 0)
				{
					Console.WriteLine($"You bought {ingredientName}.");
				}
				else
				{
					bankrupt = true;
					Console.WriteLine($"Closed! Cannot afford {ingredientName}.");
					break;
				}
			}
		}

		if (!bankrupt)
		{
			Console.WriteLine("Day completed!");
			Console.WriteLine($"Coins: {coins}");
			Console.WriteLine($"Energy: {energy}");
		}

	}
}
