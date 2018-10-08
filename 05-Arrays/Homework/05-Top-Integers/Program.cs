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

		List<int> topInts = new List<int>();
	
		for (int i = 0; i < nums.Length; i++)
		{
			bool isTop = true;
			for (int j = i+1; j < nums.Length; j++)
			{
				if (nums[i] <= nums[j])
				{
					isTop = false;
					break;
				}
			}

			if (isTop)
			{
				topInts.Add(nums[i]);
			}
		}

		Console.WriteLine(string.Join(" ", topInts));
	}
}
