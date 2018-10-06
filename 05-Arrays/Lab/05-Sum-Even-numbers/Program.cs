using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

		int sum = 0;
		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] % 2 == 0)
			{
				sum += nums[i];
			}
		}

		Console.WriteLine(sum);

	}
}
