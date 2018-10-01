using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{

		decimal pounds = decimal.Parse(Console.ReadLine());
		decimal dollars = pounds * 1.31M;

		Console.WriteLine($"{dollars:f3}");

	}
}
