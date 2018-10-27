using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string batch = Console.ReadLine();

		List<int> bestBatch = new List<int>();

		int maxSum = -999999;
		double averageQuality = -999999;
		int minLength = 999;
		while (batch != "Bake It!")
		{
			List<int> batchQuality = batch.Split('#').Select(int.Parse).ToList();

			int sum = batchQuality.Sum();
			if (sum > maxSum)
			{
				bestBatch = batchQuality;
				maxSum = sum;
				averageQuality = batchQuality.Average();
				minLength = batchQuality.Count;
			}else if (sum == maxSum)
			{
				if (batchQuality.Average() > averageQuality)
				{
					averageQuality = batchQuality.Average();
					bestBatch = batchQuality;
					maxSum = batchQuality.Sum();
					minLength = batchQuality.Count;
				}else if (batchQuality.Average() == averageQuality)
				{
					if (batchQuality.Count < minLength)
					{
						minLength = batchQuality.Count;
						bestBatch = batchQuality;
						averageQuality = batchQuality.Average();
						maxSum = batchQuality.Sum();
					}
				}
			}

			batch = Console.ReadLine();
		}

		Console.WriteLine($"Best Batch quality: {bestBatch.Sum()}");
		Console.WriteLine(string.Join(" ",bestBatch));
	}
}
