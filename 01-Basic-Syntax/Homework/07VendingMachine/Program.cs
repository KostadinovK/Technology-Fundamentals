using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program {
		
	static void Main(string[] args) {
		const double COIN_01 = 0.1;
		const double COIN_02 = 0.2;
		const double COIN_05 = 0.5;
		const double COIN_1 = 1;
		const double COIN_2 = 2;
		const double NUTS_PRICE = 2.0;
		const double WATER_PRICE = 0.7;
		const double CRISPS_PRICE = 1.5;
		const double SODA_PRICE = 0.8;
		const double COKE_PRICE = 1.0;

		double sum = 0;
		string line = Console.ReadLine();
		while(line != "Start") {
			double coin = double.Parse(line);
			if(coin == COIN_01 || coin == COIN_02 || coin == COIN_05 || coin == COIN_1 || coin == COIN_2){ 
				sum += coin;
			}else{
				Console.WriteLine($"Cannot accept {coin}");
			}
			line = Console.ReadLine();
		}

		string product = Console.ReadLine();
		while(product != "End"){ 
			if(product == "Nuts" || product == "Water" || product == "Crisps" || product == "Soda" || product == "Coke"){ 
				if(product == "Nuts") {
					if (sum < NUTS_PRICE) {
						Console.WriteLine("Sorry, not enough money");
					}else{
						Console.WriteLine($"Purchased nuts");
						sum -= NUTS_PRICE;
					}
				}else if(product == "Water") {
					if (sum < WATER_PRICE)
					{
						Console.WriteLine("Sorry, not enough money");
					}
					else
					{
						Console.WriteLine($"Purchased water");
						sum -= WATER_PRICE;
					}
				}else if(product == "Crisps") {
					if (sum < CRISPS_PRICE)
					{
						Console.WriteLine("Sorry, not enough money");
					}
					else
					{
						Console.WriteLine($"Purchased crisps");
						sum -= CRISPS_PRICE;
					}
				}else if(product == "Soda") {
					if (sum < SODA_PRICE)
					{
						Console.WriteLine("Sorry, not enough money");
					}
					else
					{
						Console.WriteLine($"Purchased soda");
						sum -= SODA_PRICE;
					}
				}else {
					if (sum < COKE_PRICE)
					{
						Console.WriteLine("Sorry, not enough money");
					}
					else
					{
						Console.WriteLine($"Purchased coke");
						sum -= COKE_PRICE;
					}
				}
			}else{
				Console.WriteLine("Ïnvalid product");
			}
			product = Console.ReadLine();

		}

		Console.WriteLine($"Change: {sum:f2}");
	}
}
