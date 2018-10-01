using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{

		char c = char.Parse(Console.ReadLine());

		if (c >= 'a' && c <= 'z')
		{
			Console.WriteLine("lower-case");
		}else if (c >= 'A' && c <= 'Z')
		{
			Console.WriteLine("upper-case");
		}

	}
}
