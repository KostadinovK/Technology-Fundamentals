using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program { 
		
	public static void Main(string[] args) {
	
		int n = int.Parse(Console.ReadLine());
		for(int j = 1;j <= n;j++) {
			string num = "";
			num += j;
			string line = "";
			for(int k = 0;k < j;k++){
				Console.Write(num + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	
		
	}
	
}
