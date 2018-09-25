using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
		List<int> numbers = new List<int>();
		int num1 = int.Parse(Console.ReadLine());
		numbers.Add(num1);

		int num2 = int.Parse(Console.ReadLine());
		numbers.Add(num2);

		int num3 = int.Parse(Console.ReadLine());
		numbers.Add(num3);

		numbers.Sort();

		for(int i = numbers.Count-1;i >= 0;i--) {
			Console.WriteLine(numbers[i]);
		}
	}
}
