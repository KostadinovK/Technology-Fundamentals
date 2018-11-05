using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Vehicle
{
	public string Type { get; set; }
	public string Model { get; set; }
	public string Color { get; set; }
	public int Hp { get; set; }

	public Vehicle(string type, string model, string color, int hp)
	{
		this.Type = type.ToLower();
		this.Model = model;
		this.Color = color;
		this.Hp = hp;
	}


	public override string ToString()
	{
		StringBuilder res = new StringBuilder();
		if (this.Type == "truck")
		{
			res.Append($"Type: Truck" + '\n');
		}
		else
		{
			res.Append($"Type: Car" + '\n');
		}
		res.Append($"Model: {this.Model}" + '\n');
		res.Append($"Color: {this.Color}" + '\n');
		res.Append($"Horsepower: {this.Hp}");

		return res.ToString();
	}
}

public class Program
{
	public static void Main()
	{
		List<Vehicle> vehicles = new List<Vehicle>();

		string vehicleString = Console.ReadLine();
		while (vehicleString != "End")
		{
			List<string> tokens = vehicleString.Split().ToList();
			vehicles.Add(new Vehicle(tokens[0],tokens[1],tokens[2],int.Parse(tokens[3])));

			vehicleString = Console.ReadLine();
		}

		string model = Console.ReadLine();
		while (model != "Close the Catalogue")
		{
			Console.WriteLine(vehicles.Find(x => x.Model == model));

			model = Console.ReadLine();
		}


		int cars = 0;
		double carsHP = 0;
		int trucks = 0;
		double trucksHP = 0;
		for (int i = 0;i < vehicles.Count;i++)
		{
			if (vehicles[i].Type == "car")
			{
				cars++;
				carsHP += vehicles[i].Hp;
			}else if (vehicles[i].Type == "truck")
			{
				trucks++;
				trucksHP += vehicles[i].Hp;
			}
		}

		if (cars == 0)
		{
			Console.WriteLine("Cars have average horsepower of: 0.00.");
		}
		else
		{
			Console.WriteLine($"Cars have average horsepower of: {(carsHP / cars):f2}.");
		}

		if (trucks == 0)
		{
			Console.WriteLine("Trucks have average horsepower of: 0.00.");
		}
		else
		{
			Console.WriteLine($"Trucks have average horsepower of: {(trucksHP/trucks):f2}.");
		}
	}
}
