using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

public class Program
{
	public static void Main()
	{
		const int DAY_PROFIT = 50;

		int partySize = int.Parse(Console.ReadLine());
		int days = int.Parse(Console.ReadLine());
		int gainedCoins = 0;

		for (int day = 1; day <= days;day++) {
			if (day % 10 == 0)
			{
				partySize -= 2;
			}

			if (day % 15 == 0)
			{
				partySize += 5;
			}

			gainedCoins += DAY_PROFIT - (2 * partySize);

			if (day % 3 == 0)
			{
				gainedCoins -= 3 * partySize;
			}

			if (day % 5 == 0)
			{
				gainedCoins += 20 * partySize;
			}

			if (day % 5 == 0 && day % 3 == 0)
			{
				gainedCoins -= 2 * partySize;
			}

		}



		Console.WriteLine($"{partySize} companions received {gainedCoins / partySize} coins each.");
	}
}
