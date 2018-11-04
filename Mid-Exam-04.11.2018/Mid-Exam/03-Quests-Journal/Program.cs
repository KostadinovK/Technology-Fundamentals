using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		List<string> quests = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();

		string command = Console.ReadLine();

		while (command != "Retire!")
		{
			List<string> tokens = command.Split(new string[]{" - "},StringSplitOptions.RemoveEmptyEntries).ToList();

			if (tokens[0] == "Start")
			{
				string quest = tokens[1];
				if (!quests.Contains(quest))
				{
					quests.Add(quest);
				}
			}else if (tokens[0] == "Complete")
			{
				string quest = tokens[1];
				if (quests.Contains(quest))
				{
					quests.Remove(quest);
				}

			}else if (tokens[0] == "Side Quest")
			{
				string questPair = tokens[1];
				List<string> questAndSideQuest = questPair.Split(':').ToList();

				if (quests.Contains(questAndSideQuest[0]) && !quests.Contains(questAndSideQuest[1]))
				{
					int index = quests.FindIndex(x => x == questAndSideQuest[0]);
					quests.Insert(index + 1, questAndSideQuest[1]);
				}

			}else if (tokens[0] == "Renew")
			{
				string quest = tokens[1];

				if (quests.Contains(quest))
				{
					quests.Remove(quest);
					quests.Add(quest);
				}
			}
			command = Console.ReadLine();
		}

		Console.WriteLine(string.Join(", ",quests));
	}
}
