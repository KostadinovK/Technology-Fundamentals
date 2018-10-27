using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		decimal budget = decimal.Parse(Console.ReadLine());
		int students = int.Parse(Console.ReadLine());
		decimal flourPackagePrice = decimal.Parse(Console.ReadLine());
		decimal eggPrice = decimal.Parse(Console.ReadLine());
		decimal apronPrice = decimal.Parse(Console.ReadLine());
		decimal neededMoney = 0;

		int freePackages = students / 5;
		int packagesNeeded = students - freePackages;

		decimal moneyForPackages = packagesNeeded * flourPackagePrice;
		neededMoney += moneyForPackages;
		decimal moneyForEggs = 10 * students * eggPrice;
		neededMoney += moneyForEggs;

		decimal apronCount = (decimal)(students + students * 0.2);
		apronCount = Math.Ceiling(apronCount);

		decimal moneyForAprons = apronPrice * apronCount;
		neededMoney += moneyForAprons;
		if (neededMoney <= budget)
		{
			Console.WriteLine($"Items purchased for {neededMoney:f2}$.");
		}
		else
		{
			Console.WriteLine($"{(neededMoney - budget):f2}$ more needed.");
		}
	}
}
