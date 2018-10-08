using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main(string[] args)
	{
		int dnaLength = int.Parse(Console.ReadLine());

		string line = Console.ReadLine();

		int maxOnes = 0;
		int maxSum = 0;
		int minStart = 9999;
		List<int> bestDNA = new List<int>();
		int bestPos = -1;
		int dnaCount = 0;
		while (line != "Clone them!")
		{
			List<int> dna = line.Split('!').Select(int.Parse).ToList();
			dnaCount++;
			int ones = 0;
			int sum = 0;
			bool isStartMarked = false;
			int start = -1;
			for (int i = 0; i < dna.Count-1; i++)
			{
				sum += dna[i];
				if (dna[i] == dna[i+1] && dna[i] == 1)
				{
					if (!isStartMarked)
					{
						isStartMarked = true;
						start = i;
					}
					ones++;
				}
			}

			sum += dna[dna.Count - 1];

			if (ones > maxOnes || start < minStart)
			{
				maxOnes = ones;
				bestDNA = dna;
				maxSum = sum;
				bestPos = dnaCount;
				minStart = start;
			}

			if (start == minStart && ones == maxOnes && sum > maxSum)
			{
				maxOnes = ones;
				bestDNA = dna;
				maxSum = sum;
				bestPos = dnaCount;
				minStart = start;
			}


			line = Console.ReadLine();
		}

		Console.WriteLine($"Best DNA sample {bestPos} with sum: {maxSum}.");
		Console.WriteLine(string.Join(" ",bestDNA));
	}
}
