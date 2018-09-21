using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
		
	static void Main(string[] args) {
		
		int num = int.Parse(Console.ReadLine());
		int from = int.Parse(Console.ReadLine());

		if(from > 10) {
			Console.WriteLine($"{num} X {from} = {from*num}");
		}else {
			for(int i = from;i <= 10;i++) {
				Console.WriteLine($"{num} X {i} = {i*num}");
			}
		
		}
	
	}
}
