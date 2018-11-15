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

		StringBuilder res = new StringBuilder();
		HashSet<char> uniqueChars = new HashSet<char>();
		string toPrint = "";
		string timesStr = "";
		for (int i = 0;i < input.Length;i++)
		{
			if (input[i] < '0' || input[i] > '9')
			{
				toPrint += input[i];
				char upper = input[i].ToString().ToUpper()[0];
				uniqueChars.Add(upper);
			}
			else
			{
				int num = 0;

				if (i == input.Length - 1)
				{
					num = int.Parse(input[i].ToString());
				}
				else
				{
					if (!char.IsNumber(input[i + 1]))
					{
						num = int.Parse(input[i].ToString());
					}
					else
					{
						num = int.Parse(input[i] + input[i + 1].ToString());
						i += 1;
					}

				}
				toPrint = toPrint.ToUpper();
				for (int j = 0; j < num; j++)
				{
					
					res.Append(toPrint);
					
				}
				toPrint = "";
			}

		}

		string output = res.ToString();
		Console.WriteLine("Unique symbols used: " + output.Distinct().Count());
		Console.WriteLine(output);
	}
}
