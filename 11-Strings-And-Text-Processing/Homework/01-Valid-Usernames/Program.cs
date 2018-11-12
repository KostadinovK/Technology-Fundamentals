using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<string> usernames = Console.ReadLine().Split(new string[]{", "},StringSplitOptions.None).ToList();
		for (int i = 0;i < usernames.Count;i++)
		{
			if (NameIsValid(usernames[i]))
			{
				Console.WriteLine(usernames[i]);
			}
		}
	}

	private static bool NameIsValid(string name)
	{
		if (name.Length >= 3 && name.Length <= 16)
		{
			for (int i = 0; i < name.Length;i++) 
			{
				if ((name[i] >= 'a' && name[i] <= 'z') || (name[i] >= 'A' && name[i] <= 'Z') || (name[i] >= '0' && name[i] <= '9') || name[i] == '_' || name[i] == '-')
				{
					continue;
				}
				else
				{
					return false;
				}
			}

			return true;
		}

		return false;
	}
}
