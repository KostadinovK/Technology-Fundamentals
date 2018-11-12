using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string text = Console.ReadLine();
		
		StringBuilder sb = new StringBuilder();
		int index = 0;
		for (int i = 0;i < text.Length;i++)
		{
			char current = text[index];
			sb.Append(current);
			for (int j = index;j < text.Length;j++)
			{
				if (current == text[j])
				{
					index++;
				}
				else
				{
					break;
				}
			}

			i = index - 1;
		}

		Console.WriteLine(sb);
	}

}
