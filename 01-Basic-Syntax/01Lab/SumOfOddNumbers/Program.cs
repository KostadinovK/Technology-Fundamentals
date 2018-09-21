using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	
	public static void Main() {
		int n = int.Parse(Console.ReadLine());
		int i = 0;
		int num = 1;
		int sum = 0;
		while(i != n) {
			if(num % 2 != 0) {
				i++;
				Console.WriteLine(num);
				sum += num;
			}
			num++;
		}

		Console.WriteLine("Sum: " + sum);

	}
}
