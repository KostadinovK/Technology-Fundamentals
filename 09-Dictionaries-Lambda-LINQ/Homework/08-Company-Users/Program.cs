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
		Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

		string line = Console.ReadLine();

		while (line != "End")
		{
			List<string> args = line.Split(new string[] {" -> "}, StringSplitOptions.None).ToList();
			string company = args[0];
			string employeeID = args[1];

			if (!companies.ContainsKey(company))
			{
				companies[company] = new List<string>();
				companies[company].Add(employeeID);
			}else if (companies.ContainsKey(company))
			{
				if (!companies[company].Contains(employeeID))
				{
					companies[company].Add(employeeID);
				}
			}

			line = Console.ReadLine();
		}

		foreach (var kvp in companies.OrderBy(x => x.Key))
		{
			Console.WriteLine(kvp.Key);
			kvp.Value.ForEach(x => Console.WriteLine("-- " + x));
		}
	}
}
