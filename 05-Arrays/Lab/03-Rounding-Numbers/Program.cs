using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		decimal[] nums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

		for (int i = 0;i < nums.Length;i++)
		{ 
			Console.WriteLine($"{nums[i]} => {Math.Ceiling(nums[i])}");
		}
	}
}
