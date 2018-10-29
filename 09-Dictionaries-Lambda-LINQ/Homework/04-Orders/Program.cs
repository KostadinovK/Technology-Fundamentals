using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{

	public static void Main()
	{
		Dictionary<string, List<double>> products = new Dictionary<string,List<double>>();

		string line = Console.ReadLine();
		while (line != "buy")
		{
			List<string> args = line.Split().ToList();
			string productName = args[0];
			double productPrice = double.Parse(args[1]);
			int quantity = int.Parse(args[2]);

			if (!products.ContainsKey(productName))
			{
				products.Add(productName, new List<double>{quantity,productPrice*quantity});
			}
			else
			{
				products[productName][0] += quantity;
				products[productName][1] = productPrice * products[productName][0];
			}

		line = Console.ReadLine();
		}

		foreach (var x in products)
		{
			Console.WriteLine($"{x.Key} -> {x.Value[1]:f2}");
		}
	}
}
