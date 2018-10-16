using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		int num = int.Parse(Console.ReadLine());

		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine(); 
		}
	}
}
