using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string bigInt = Console.ReadLine().Trim(new char[]{' ','0'});
		int digit = int.Parse(Console.ReadLine());
		if (digit == 0)
		{
			Console.WriteLine(0);
			return;
		}
		int carry = 0;
		int multiplicationRes = 0;
		
		StringBuilder sb = new StringBuilder();

		for (int i = bigInt.Length-1;i >= 0;i--)
		{
			int num = bigInt[i] - '0';
			multiplicationRes = num * digit + carry;
			carry = multiplicationRes / 10;
			multiplicationRes = multiplicationRes % 10;

			sb.Append(multiplicationRes);
		}

		if (carry > 0)
		{
			sb.Append(carry);
		}

		string res = sb.ToString();

		for (int i = res.Length-1; i >= 0;i--)
		{
			Console.Write(res[i]);
		}

		Console.WriteLine();
	}
}
