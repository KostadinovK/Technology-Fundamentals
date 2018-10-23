using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

		string command = Console.ReadLine();
		while (command != "end")
		{
			List<string> args = command.Split().ToList();
			if (args[0] == "Delete")
			{
				nums.RemoveAll(x => x == int.Parse(args[1]));
			}else if (args[0] == "Insert")
			{
				nums.Insert(int.Parse(args[2]),int.Parse(args[1]));
			}

			command = Console.ReadLine();
		}

		Console.WriteLine(string.Join(" ", nums));
	}
}
