using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		Dictionary<string,List<string>> forceBook = new Dictionary<string, List<string>>();

		string line = Console.ReadLine();
		while (line != "Lumpawaroo")
		{
			for (int i = 0; i < line.Length; i++)
			{
				if (line[i] == '|')
				{
					List<string> args = line.Split(new string[] { " | " }, StringSplitOptions.None).ToList();
					string forceSide = args[0];
					string forceUser = args[1];

					if (!forceBook.ContainsKey(forceSide))
					{
						forceBook[forceSide] = new List<string>();
						forceBook[forceSide].Add(forceUser);
					}
					else
					{
						if (!forceBook[forceSide].Contains(forceUser))
						{
							forceBook[forceSide].Add(forceUser);
						}
					}
					break;
				}

				if (line[i] == '>')
				{
					List<string> args = line.Split(new string[] { " -> " }, StringSplitOptions.None).ToList();
					string forceSide = args[1];
					string forceUser = args[0];

					if (ForceUserExist(forceUser,forceBook))
					{
						RemoveForceUser(forceUser,ref forceBook);
					}
					
					forceBook[forceSide].Add(forceUser);
					Console.WriteLine($"{forceUser} joins the {forceSide} side!");
					break;
				}
			}
			line = Console.ReadLine();
		}

		foreach (var kvp in forceBook.Where(x => x.Value.Count > 0).OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
		{
			Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");
			kvp.Value.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine("! " + x));
		}


	}

	private static void RemoveForceUser(string forceUser, ref Dictionary<string, List<string>> forceBook)
	{
		foreach (var kvp in forceBook)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (forceUser == kvp.Value[i])
				{
					kvp.Value.Remove(forceUser);
					break;
				}
			}
		}
	}

	private static bool ForceUserExist(string forceUser, Dictionary<string, List<string>> forceBook)
	{
		foreach (var kvp in forceBook)
		{
			for (int i = 0; i < kvp.Value.Count; i++)
			{
				if (forceUser == kvp.Value[i])
				{
					return true;
				}
			}
		}

		return false;
	}
}
