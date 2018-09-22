using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
	
		int games = int.Parse(Console.ReadLine());

		double headsetPrice = double.Parse(Console.ReadLine());
		double mousePrice = double.Parse(Console.ReadLine());
		double keyboardPrice = double.Parse(Console.ReadLine());
		double displayPrice = double.Parse(Console.ReadLine());
		double expenses = 0;
		int game = 1;
		int timesBeforeDisplayTrashed = 0;
		while(game <= games) {

			if(game % 2 == 0 && game % 3 != 0) {
				expenses += headsetPrice;
			}

			if(game % 3 == 0 && game % 2 != 0) { 
				expenses += mousePrice;
			}

			if(game % 2 == 0 && game % 3 == 0){ 
				expenses += mousePrice;
				expenses += headsetPrice;
				expenses += keyboardPrice;
				timesBeforeDisplayTrashed++;
			}

			if(timesBeforeDisplayTrashed == 2)	{ 
				expenses += displayPrice;
				timesBeforeDisplayTrashed = 0;
			}
			game++;
		}

		Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
	
	}
}
