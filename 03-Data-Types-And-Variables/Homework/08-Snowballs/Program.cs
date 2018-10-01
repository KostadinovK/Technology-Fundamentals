using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

public class Program
{
	public static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		PrintSnowballValue(n);
	}

	public static void PrintSnowballValue(int n)
	{
		BigInteger snowballValue = 0;
		int snow = 0;
		int time = 0;
		int quality = 0;

		for (int i = 0; i < n; i++)
		{
			int snowballSnow = int.Parse(Console.ReadLine());
			int snowballTime = int.Parse(Console.ReadLine());
			int snowballQuality = int.Parse(Console.ReadLine());

			BigInteger snowballValueCurrent = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

			if (snowballValueCurrent > snowballValue)
			{
				snowballValue = snowballValueCurrent;
				snow = snowballSnow;
				time = snowballTime;
				quality = snowballQuality;
			}
		}
		Console.WriteLine($"{snow} : {time} = {snowballValue} ({quality})");
	}
}
