using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
	public static void Main(string[] args)
	{
		List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
		bool ifExists = false;
		for (int i = 0; i < nums.Count(); i++)
		{
			
			if (nums.Take(i).Sum() == nums.Skip(i + 1).Sum())
			{
				Console.WriteLine(i);
				ifExists = true;
				break;
			}
		}

		if (!ifExists)
		{
			Console.WriteLine("no");
		}
	}

}
