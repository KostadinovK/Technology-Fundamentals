using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	public static void Main()
	{
		List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

		string command = Console.ReadLine();

		while (command != "End")
		{
			List<string> args = command.Split().ToList();

			if (args[0] == "Add")
			{
				nums.Add(int.Parse(args[1]));
			}else if (args[0] == "Insert")
			{
				if (int.Parse(args[2]) >= 0 && int.Parse(args[2]) < nums.Count)
				{
					nums.Insert(int.Parse(args[2]),int.Parse(args[1]));
				}
				else
				{
					Console.WriteLine("Invalid index");
				}
			}else if (args[0] == "Remove")
			{
				if (int.Parse(args[1]) >= 0 && int.Parse(args[1]) < nums.Count)
				{
					nums.RemoveAt(int.Parse(args[1]));
				}
				else
				{
					Console.WriteLine("Invalid index");
				}
			}else if (args[0] == "Shift")
			{
				if (args[1] == "left")
				{
					nums = ShiftLeft(nums,int.Parse(args[2]));
				}
				else
				{
					nums = ShiftRight(nums, int.Parse(args[2]));
					
				}

			}

			command = Console.ReadLine();
		}

		Console.WriteLine(string.Join(" ",nums));
	}

	private static List<int> ShiftLeft(List<int> nums, int count)
	{
		for (int i = 0; i < count; i++)
		{
			List<int> temp = new List<int>();

			for (int j = 1; j < nums.Count; j++)
			{
				temp.Add(nums[j]);
			}

			temp.Add(nums[0]);

			nums = temp;
		}

		return nums;


	}

	private static List<int> ShiftRight(List<int> nums, int count)
	{
		for (int i = 0; i < count; i++)
		{
			List<int> temp = new List<int>();
			temp.Add(nums[nums.Count-1]);
			for (int j = 0; j < nums.Count-1; j++)
			{
				temp.Add(nums[j]);
			}


			nums = temp;
		}

		return nums;

	}
}
