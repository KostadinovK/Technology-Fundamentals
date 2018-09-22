using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program {
	
	public static void Main(string[] args) {
		int peoples = int.Parse(Console.ReadLine());
		string groupType = Console.ReadLine();
		string day = Console.ReadLine();
		double pricePerDay = 0;
		double price = 0;
		if(groupType == "Students") { 
			if(day == "Monday"){
				pricePerDay = 9.5;
				price = peoples * pricePerDay;
			}else if(day == "Tuesday"){ 
				pricePerDay = 8;
				price = peoples * pricePerDay;
			}else if(day == "Wednesday"){ 
				pricePerDay = 6.85;
				price = peoples * pricePerDay;
			}else if(day == "Thursday"){ 
				pricePerDay = 7.15;
				price = peoples * pricePerDay;
			}else if(day == "Friday"){ 
				pricePerDay = 8.45;
				price = peoples * pricePerDay;
			}else if(day == "Saturday"){ 
				pricePerDay = 9.80;
				price = peoples * pricePerDay;
			}else if(day == "Sunday"){ 
				pricePerDay = 10.46;
				price = peoples * pricePerDay;
			}
		}else if(groupType == "Business"){
			if (day == "Monday")
			{
				pricePerDay = 11.80;
				price = peoples * pricePerDay;
			}
			else if (day == "Tuesday")
			{
				pricePerDay = 14.50;
				price = peoples * pricePerDay;
			}
			else if (day == "Wednesday")
			{
				pricePerDay = 12.60;
				price = peoples * pricePerDay;
			}
			else if (day == "Thursday")
			{
				pricePerDay = 13.20;
				price = peoples * pricePerDay;
			}
			else if (day == "Friday")
			{
				pricePerDay = 10.90;
				price = peoples * pricePerDay;
			}
			else if (day == "Saturday")
			{
				pricePerDay = 15.60;
				price = peoples * pricePerDay;
			}
			else if (day == "Sunday")
			{
				pricePerDay = 16;
				price = peoples * pricePerDay;
			}
		}else if(groupType == "Regular"){
			if (day == "Monday")
			{
				pricePerDay = 15;
				price = peoples * pricePerDay;
			}
			else if (day == "Tuesday")
			{
				pricePerDay = 15;
				price = peoples * pricePerDay;
			}
			else if (day == "Wednesday")
			{
				pricePerDay = 14.80;
				price = peoples * pricePerDay;
			}
			else if (day == "Thursday")
			{
				pricePerDay = 13.90;
				price = peoples * pricePerDay;
			}
			else if (day == "Friday")
			{
				pricePerDay = 15;
				price = peoples * pricePerDay;
			}
			else if (day == "Saturday")
			{
				pricePerDay = 20;
				price = peoples * pricePerDay;
			}
			else if (day == "Sunday")
			{
				pricePerDay = 22.50;
				price = peoples * pricePerDay;
			}
		}

		if(groupType == "Students" && peoples >= 30){ 
			price = price - (price * 15 / 100);
		}

		if(groupType == "Business" && peoples >= 100){ 
			price -= pricePerDay * 10;
		}

		if(groupType == "Regular" && peoples >= 10 && peoples <= 20){ 
			price = price - (price * 5 / 100);
		}

		if (groupType == "Regular" && peoples >= 21)
		{
			price = price - (price * 9 / 100);
		}

		if(day == "Sunday" && groupType == "Business"){
			price = price - (price * 12 / 100);
		}

		if(day == "Sunday" && groupType == "Regular"){
			price = price - (price * 10 / 100);
		}

		Console.WriteLine($"Total price: {price:f2}");
	}
}
