using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main() {

		int n = int.Parse(Console.ReadLine());
		int sum = 0;
		while (n != 0)
		{
			int digit = n % 10;
			sum += digit;
			n /= 10;
		}

		Console.WriteLine(sum);
	}
}
