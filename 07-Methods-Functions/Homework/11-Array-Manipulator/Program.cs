using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;


public class Program
{
	public static void Main()
	{
		List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

		string line = Console.ReadLine();
		while (line != "end")
		{
			var args = line.Split();
			if (args[0] == "exchange")
			{
				int index = int.Parse(args[1]);
				if (index >= 0 && index < nums.Count)
				{
					nums = ExchangeList(nums, index);
				}
				else
				{
					Console.WriteLine("Invalid index");
				}

			}else if (args[0] == "min")
			{
				int index = GetMin(nums, args[1]);
				if (index >= 0)
				{
					Console.WriteLine(index);
				}
				else
				{
					Console.WriteLine("No matches");
				}
				
			}else if (args[0] == "max")
			{
				int index = GetMax(nums, args[1]);
				if (index >= 0)
				{
					Console.WriteLine(index);
				}
				else
				{
					Console.WriteLine("No matches");
				}

			}
			else if (args[0] == "first")
			{
				PrintFirstElements(nums,int.Parse(args[1]),args[2]);
			}else if (args[0] == "last")
			{
				PrintLastElements(nums, int.Parse(args[1]), args[2]);
			}
			else
			{
				Console.WriteLine("Invalid command!");
			}

			line = Console.ReadLine();
		}

		string res = "[";
		for (int i = 0; i < nums.Count; i++)
		{
			if (i != nums.Count - 1)
			{
				res += nums[i] + ", ";
			}
			else
			{
				res += nums[i] + "]";
			}
		}

		Console.WriteLine(res);
	}

	private static List<int> ExchangeList(List<int> nums, int index)
	{
		List<int> res = new List<int>();

		for (int i = index+1; i < nums.Count;i++) {
			res.Add(nums[i]);
		}

		for (int i = 0; i <= index; i++)
		{
			res.Add(nums[i]);
		}

		return res;
	}

	private static int GetMin(List<int> nums, string s)
	{

		int min = Int32.MaxValue;
		int minIndex = -1;

		for (int i = 0; i < nums.Count; i++)
		{
			if (s == "even")
			{
				if (nums[i] <= min && nums[i] % 2 == 0)
				{
					min = nums[i];
					minIndex = i;
				}
			}
			else
			{
				if (nums[i] <= min && nums[i] % 2 != 0)
				{
					min = nums[i];
					minIndex = i;
				}
			}
		}

		return minIndex;
	}

	private static int GetMax(List<int> nums, string s)
	{
		int max = Int32.MinValue;
		int maxIndex = -1;

		for (int i = 0; i < nums.Count; i++)
		{
			if (s == "even")
			{
				if (nums[i] >= max && nums[i] % 2 == 0)
				{
					max = nums[i];
					maxIndex = i;
				}
			}
			else
			{
				if (nums[i] >= max && nums[i] % 2 != 0)
				{
					max = nums[i];
					maxIndex = i;
				}
			}
		}

		return maxIndex;
	}

	private static void PrintFirstElements(List<int> nums, int amount, string s)
	{
		if (amount > nums.Count)
		{
			Console.WriteLine("Invalid count");
			return;
		}

		List<int> firstElements = new List<int>();
		for (int i = 0; i < nums.Count; i++)
		{
			if (s == "even")
			{
				if (nums[i] % 2 == 0)
				{
					firstElements.Add(nums[i]);
				}
			}
			else
			{
				if (nums[i] % 2 != 0)
				{
					firstElements.Add(nums[i]);
				}
			}

			if (firstElements.Count == amount)
			{
				break;
			}
		}

		if (firstElements.Count == 0)
		{
			Console.WriteLine("[]");
		}
		else
		{
			string res = "[";
			for (int i = 0;i < firstElements.Count;i++)
			{
				if (firstElements.Count - 1 != i)
				{
					res += firstElements[i] + ", ";
				}
				else
				{
					res += firstElements[i] + "]";
				}
			}

			Console.WriteLine(res);
		}
	}

	private static void PrintLastElements(List<int> nums, int amount, string s)
	{
		if (amount > nums.Count)
		{
			Console.WriteLine("Invalid count");
			return;
		}

		List<int> lastElements = new List<int>();
		for (int i = nums.Count-1; i >= 0;i--)
		{
			if (s == "even")
			{
				if (nums[i] % 2 == 0)
				{
					lastElements.Add(nums[i]);	
				}
			}
			else
			{
				if (nums[i] % 2 != 0)
				{
					lastElements.Add(nums[i]);
				}
			}

			if (lastElements.Count == amount)
			{
				break;
			}
		}

		if (lastElements.Count == 0)
		{
			Console.WriteLine("[]");
		}
		else
		{
			string res = "[";
			for (int i = lastElements.Count-1; i >= 0; i--)
			{
				if (i != 0)
				{
					res += lastElements[i] + ", ";
				}
				else
				{
					res += lastElements[i] + "]";
				}
			}

			Console.WriteLine(res);
		}

	}
}

