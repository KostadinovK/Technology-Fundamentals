using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public double Grade { get; set; }

	public Student(string firstName, string lastName, double grade)
	{
		this.FirstName = firstName;
		this.LastName = lastName;
		this.Grade = grade;
	}

	public override string ToString()
	{
		return $"{FirstName} {LastName}: {Grade:f2}";
	}
}

public class Program
{
	public static void Main()
	{
		List<Student> students = new List<Student>();

		int n = int.Parse(Console.ReadLine());
		for (int i = 0;i < n;i++)
		{
			List<string> args = Console.ReadLine().Split().ToList();
			students.Add(new Student(args[0],args[1],double.Parse(args[2])));
		}

		students = students.OrderByDescending(x => x.Grade).ToList();

		Console.WriteLine(string.Join("\n",students));
	}
}
