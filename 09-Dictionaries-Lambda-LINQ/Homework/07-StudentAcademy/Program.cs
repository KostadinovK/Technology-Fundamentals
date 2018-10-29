using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();
		int n = int.Parse(Console.ReadLine());

		for (int i = 0; i < n; i++)
		{
			string studentName = Console.ReadLine();
			double grade = double.Parse(Console.ReadLine());

			if (!studentGrades.ContainsKey(studentName))
			{
				studentGrades[studentName] = new List<double>();
			}

			studentGrades[studentName].Add(grade);
		}

		studentGrades = studentGrades.Where(x => x.Value.Average() >= 4.5).OrderByDescending(x => x.Value.Average()).ToDictionary(x => x.Key, x => x.Value);

		foreach (var kvp in studentGrades)
		{
			Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
			
		}
	}
}
