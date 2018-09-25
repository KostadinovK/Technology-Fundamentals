using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
		
		string word = Console.ReadLine();
		char[] arr = word.ToCharArray();
		Array.Reverse(arr);
		Console.WriteLine(arr);
	}
}
