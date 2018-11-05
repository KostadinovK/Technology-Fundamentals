using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
	public string Name { get; set; }
	public string ID { get; set; }
	public int Age { get; set; }

	public Person(string name, string id, int age)
	{
		this.Name = name;
		this.ID = id;
		this.Age = age;
	}

	public override string ToString()
	{
		return this.Name + " with ID: " + this.ID + " is " + this.Age + " years old.";
	}
}

public class Program
{
	public static void Main()
	{
		List<Person> persons = new List<Person>();

		string command = Console.ReadLine();
		while (command != "End")
		{
			List<string> tokens = command.Split().ToList();
			persons.Add(new Person(tokens[0],tokens[1], int.Parse(tokens[2])));

			command = Console.ReadLine();
		}

		persons = persons.OrderBy(x => x.Age).ToList();
		Console.WriteLine(string.Join("\n",persons));
	}
}
