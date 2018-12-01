using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        string wordsDefinitions= Console.ReadLine();
        List<string> wordsToSearch = Console.ReadLine().Split(" | ").ToList();
        string command = Console.ReadLine();

        List<string> words = wordsDefinitions.Split(" | ").ToList();
        for (int i = 0;i < words.Count;i++)
        {
            List<string> wordAndMeaning = words[i].Split(": ").ToList();
            if (!dictionary.ContainsKey(wordAndMeaning[0]))
            {
                dictionary.Add(wordAndMeaning[0],new List<string>{wordAndMeaning[1]});
            }
            else
            {
                dictionary[wordAndMeaning[0]].Add(wordAndMeaning[1]);
            }
        }

        for (int i = 0;i < wordsToSearch.Count;i++)
        {
            if (dictionary.ContainsKey(wordsToSearch[i]))
            {
                dictionary[wordsToSearch[i]] = dictionary[wordsToSearch[i]].OrderByDescending(x => x.Length).ToList();

                Console.WriteLine(wordsToSearch[i]);
                for (int j = 0;j < dictionary[wordsToSearch[i]].Count;j++)
                {
                    Console.WriteLine("-" + dictionary[wordsToSearch[i]][j]);
                }
            }
        }

        if (command == "List")
        {
            foreach (var kvp in dictionary.OrderBy(x => x.Key))
            {
                Console.Write(kvp.Key + " ");
            }
        }
    }
}
