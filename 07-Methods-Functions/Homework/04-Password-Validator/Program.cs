using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string password = Console.ReadLine();

		ValidatePassword(password);
	}

	private static void ValidatePassword(string password)
	{
		bool isBetween6And10Chars = true;
		if (password.Length < 6 || password.Length > 10)
		{
			
			isBetween6And10Chars = false;
		}

		bool isOnlyWithLettersAndDigits = true;
		int digits = 0;
		for (int i = 0;i < password.Length;i++)
		{
			if ((password[i] >= 'a' && password[i] <= 'z') || (password[i] >= 'A' && password[i] <= 'Z') || (password[i] >= '0' && password[i] <= '9'))
			{

				if (password[i] >= '0' && password[i] <= '9')
				{
					digits++;
				}
			}
			else
			{
				isOnlyWithLettersAndDigits = false;
			}
		}

		bool isWithMoreThan2Digits = true;
		if (digits < 2)
		{
			isWithMoreThan2Digits = false;
		}

		if (isBetween6And10Chars && isOnlyWithLettersAndDigits && isWithMoreThan2Digits)
		{
			Console.WriteLine("Password is valid");
		}
		else
		{
			if (!isBetween6And10Chars)
			{
				Console.WriteLine("Password must be between 6 and 10 characters ");
			}

			if (!isOnlyWithLettersAndDigits)
			{
				Console.WriteLine("Password must consist only of letters and digits");
			}

			if (!isWithMoreThan2Digits)
			{
				Console.WriteLine("Password must have at least 2 digits");
			}
		}

	}
}
