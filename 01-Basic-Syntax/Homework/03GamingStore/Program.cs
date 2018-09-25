using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
		
		Dictionary<string,decimal> gameToPriceDict = new Dictionary<string, decimal>{ 
			{"OutFall 4",39.99M},{"CS:OG",15.99M},{"Zplinter Zell",19.99M},{"Honored 2",59.99M},{"RoverWatch",29.99M},{"RoverWatch Origins Edition",39.99M}
		};
		
		decimal money = decimal.Parse(Console.ReadLine());
		decimal startMoney = money;
		string line = Console.ReadLine();
		bool programEnd = false;
		while(line != "Game Time") { 
			
			if(!gameToPriceDict.ContainsKey(line)) {
				Console.WriteLine("Not Found");
			}else {
				if(money < gameToPriceDict[line]) {
					Console.WriteLine("Too Expensive");
				}else {
					var keys = from entry in gameToPriceDict where entry.Value == gameToPriceDict[line] select entry.Key;
					foreach (var key in keys)
						Console.WriteLine("Bought " + key);

					money -= gameToPriceDict[line];
					if (money <= 0)
					{
						Console.WriteLine("Out of money!");
						programEnd = true;
						break;
					}
				}
			}

			line = Console.ReadLine();
		}
		if(!programEnd) {
			Console.WriteLine($"Total spent: ${startMoney - money:f2}. Remaining: ${money:f2}");
		}
	}
}
