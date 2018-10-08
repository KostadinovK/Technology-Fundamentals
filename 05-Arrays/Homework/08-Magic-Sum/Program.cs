using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

		int sum = int.Parse(Console.ReadLine());

		List<int> pairs = new List<int>();

		for (int i = 0; i < nums.Length-1; i++)
		{
			for (int j = i+1; j < nums.Length; j++)
			{
				if (nums[i] + nums[j] == sum)
				{
					pairs.Add(nums[i]);
					pairs.Add(nums[j]);
				}
			}
		}

		for (int i = 0; i < pairs.Count; i+=2)
		{
			Console.WriteLine(pairs[i] + " " + pairs[i+1]);
		}
	}
}
