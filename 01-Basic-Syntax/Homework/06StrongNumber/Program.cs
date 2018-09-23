using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program {

	public static bool IsStrong(long number)
	{
		long fact;
		long num = number;
		long sum = 0;

		while (number != 0)
		{
			fact = 1;

			for (int i = 1; i <= number % 10; ++i){
				fact *= i;
			}
				

			sum += fact;

			number /= 10;
		}

		return sum == num;
	}
	public static void Main(string[] args) {
		
			long number = long.Parse(Console.ReadLine());
			if(IsStrong(number)){
				Console.WriteLine("yes");
			}else{
				Console.WriteLine("no");
			}
		
		}

}
