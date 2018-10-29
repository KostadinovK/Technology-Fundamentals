using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	public static void Main()
	{
		Dictionary<string,List<string>> courses = new Dictionary<string, List<string>>();
		string line = Console.ReadLine();
		while (line != "end")
		{
			List<string> args = line.Split(new string[] { " : " }, StringSplitOptions.None).ToList();
			string courseName = args[0];
			string studentName = args[1];
			if (!courses.ContainsKey(courseName))
			{
				courses[courseName] = new List<string>();
			}

			courses[courseName].Add(studentName);

			line = Console.ReadLine();
		}

		foreach (var kvp in courses.OrderByDescending(x => x.Value.Count))
		{
			Console.WriteLine(kvp.Key + ": " + kvp.Value.Count);
			kvp.Value.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine("-- " + x));
		}
	}
}
