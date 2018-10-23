using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
		List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();

		while (true)
		{
			if (cards1.Count == 0) break;

			if (cards2.Count == 0) break;

			if (cards1[0] > cards2[0])
			{
				cards1.Add(cards1[0]);
				cards1.Add(cards2[0]);
			}else if (cards1[0] < cards2[0])
			{
				cards2.Add(cards2[0]);
				cards2.Add(cards1[0]);
			}

			cards1.Remove(cards1[0]);
			cards2.Remove(cards2[0]);
		}

		if (cards2.Count == 0)
		{
			Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
		}
		else
		{
			Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
		}
	}
}
