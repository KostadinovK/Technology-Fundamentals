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

		List<int> longestSeq = new List<int>();
		for (int i = 0; i < nums.Count-1; i++)
		{
			List<int> seq = new List<int>();
			for (int j = i; j < nums.Count; j++)
			{
				if (nums[i] == nums[j])
				{
					seq.Add(nums[i]);
				}
				else
				{
					break;
				}
			}

			if (seq.Count > longestSeq.Count)
			{
				longestSeq = seq;
			}

			
		}

		Console.WriteLine(string.Join(" ", longestSeq));
	}
}
