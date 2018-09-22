using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program {
	public static void Main(string[] args) {
		
		decimal money = decimal.Parse(Console.ReadLine());
		int students = int.Parse(Console.ReadLine());
		decimal lightSaberPrice = decimal.Parse(Console.ReadLine());
		decimal robePrice = decimal.Parse(Console.ReadLine());
		decimal beltPrice = decimal.Parse(Console.ReadLine());

		int lightSabers = (int)Math.Ceiling(students * 1.10);

	
		int beltCount = (students == 0) ? 0 : students - (students / 6);

		decimal sum = students * robePrice + beltCount * beltPrice + lightSabers * lightSaberPrice;

		if(sum <= money) {
			Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
		}else {
			Console.WriteLine($"Ivan Cho will need {sum - money:f2}lv more.");
		}
	}
}
