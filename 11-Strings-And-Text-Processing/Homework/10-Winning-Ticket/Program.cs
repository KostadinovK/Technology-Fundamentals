using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
	public static void Main()
	{
		List<string> tickets = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

		for (int i = 0;i < tickets.Count;i++)
		{
			string ticket = tickets[i];
			if (ticket.Length != 20)
			{
				Console.WriteLine("invalid ticket");
				continue;
			}

			string leftSide = ticket.Substring(0, 10);
			string rightSide = ticket.Substring(10);

			char symbol = ' ';
			int matchesLength = 0;
			for (int length = 6; length <= 10;length++)
			{
				if (leftSide.Contains(new string('@',length)) && rightSide.Contains(new string('@',length)))
				{
					symbol = '@';
					matchesLength = length;
				}
				else if (leftSide.Contains(new string('$', length)) && rightSide.Contains(new string('$', length)))
				{
					symbol = '$';
					matchesLength = length;
				}
				else if (leftSide.Contains(new string('#', length)) && rightSide.Contains(new string('#', length)))
				{
					symbol = '#';
					matchesLength = length;
				}
				else if (leftSide.Contains(new string('^', length)) && rightSide.Contains(new string('^', length)))
				{
					symbol = '^';
					matchesLength = length;
				}
			}

			if (matchesLength == 0)
			{
				Console.WriteLine($"ticket \"{ticket}\" - no match");
			}else if (matchesLength >= 6 && matchesLength <= 9)
			{
				Console.WriteLine($"ticket \"{ticket}\" - {matchesLength}{symbol}");
			}
			else
			{
				Console.WriteLine($"ticket \"{ticket}\" - {matchesLength}{symbol} Jackpot!");
			}
		}
	}
}
