using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string input = Console.ReadLine();

		string toRepeat = "";
		StringBuilder sb = new StringBuilder();

		List<char> uniqueChars = new List<char>();
		string times = "";
		for (int i = 0;i < input.Length;i++)
		{
			if ((input[i] < '0' || input[i] > '9') && times.Length == 0)
			{
				toRepeat += input[i].ToString().ToUpper();
				if (!uniqueChars.Contains(input[i].ToString().ToUpper()[0]))
				{
					uniqueChars.Add(input[i].ToString().ToUpper()[0]);
				}
			}
			else if(input[i] >= '0' && input[i] <= '9')
			{
				times += input[i];
			}else if ((input[i] < '0' || input[i] > '9') && times.Length != 0)
			{
				int timesNum = int.Parse(times);
				for (int j = 0;j < timesNum;j++)
				{
					sb.Append(toRepeat);
				}

				toRepeat = "";
				times = "";
				
			}
		}

		Console.WriteLine("Unique symbols used: " + uniqueChars.Count);
		Console.WriteLine(sb);
	}
}
