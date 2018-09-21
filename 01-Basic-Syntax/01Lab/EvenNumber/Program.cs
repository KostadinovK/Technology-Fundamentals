using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	
	static bool isEven(int num) {
		return num % 2 == 0;
	}

	public static void Main(string[] args) {
		
		int num = int.Parse(Console.ReadLine());
		while(!isEven(num)) {
			Console.WriteLine("Please write an even number.");
			num = int.Parse(Console.ReadLine());
		}

		Console.WriteLine("The number is: " + num);
	}
}
