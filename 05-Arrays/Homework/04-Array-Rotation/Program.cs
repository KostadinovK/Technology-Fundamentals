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

		int numberOfRotations = int.Parse(Console.ReadLine());
		for (int i = 0;i < numberOfRotations;i++)
		{
			int[] temp = new int[nums.Length];
			int k = 0;
			for (int j = 1; j < nums.Length; j++)
			{
				temp[k] = nums[j];
				k++;
			}

			temp[k] = nums[0];
			nums = temp;
		}

		Console.WriteLine(string.Join(" ", nums));
	}
}
