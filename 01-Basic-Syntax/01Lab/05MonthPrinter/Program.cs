using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
		
		Dictionary<int,string> months = new Dictionary<int, string>{
			{1,"January"},
			{2,"February"},
			{3,"March"},
			{4,"April"},
			{5,"May"},
			{6,"June"},
			{7,"July"},
			{8,"August"},
			{9,"September"},
			{10,"October"},
			{11,"November"},
			{12,"December"}
		};

		int month = int.Parse(Console.ReadLine());
		if(months.ContainsKey(month)) {
			Console.WriteLine(months[month]);
		}else {
			Console.WriteLine("Error!");
		}
	}
}

