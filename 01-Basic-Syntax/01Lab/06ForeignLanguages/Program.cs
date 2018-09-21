using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	
	public static void Main(string[] args) {
		string country = Console.ReadLine();

		if(country == "USA" || country == "England"){
			Console.WriteLine("English");
		}else if(country == "Spain" || country == "Mexico" || country == "Argentina") {
			Console.WriteLine("Spanish");
		}else{
			Console.WriteLine("unknown");
		}


	}
}
