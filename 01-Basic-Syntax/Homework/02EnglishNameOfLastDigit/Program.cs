using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main() {
		
		Dictionary<int,string> digitToName = new Dictionary<int, string>{
			{0,"zero"}, {1,"one"}, {2,"two"}, {3,"three"}, {4,"four"}, {5,"five"}, {6,"six"}, {7,"seven"},{8,"eight"},{9,"nine"}
		};
		
		int number = int.Parse(Console.ReadLine());
		
		if(number < 10){
			Console.WriteLine(digitToName[number]);
		}else{
			Console.WriteLine(digitToName[number % 10]);	
		}
	}
}
