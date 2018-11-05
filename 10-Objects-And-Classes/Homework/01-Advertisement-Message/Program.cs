using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Message
{
	private List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
	private List<string> events = new List<string> {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
	private List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
	private List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

	public Message()
	{
	}

	public string generateText(Random random)
	{
		string res = "";
		int randomPhraseIndex = random.Next(0, phrases.Count);
		int randomEventIndex = random.Next(0, events.Count);
		int randomAuthorsIndex = random.Next(0, authors.Count);
		int randomCityIndex = random.Next(0, cities.Count);

		res += phrases[randomPhraseIndex] + " " + events[randomEventIndex] + " " + authors[randomAuthorsIndex] + " - " +
		       cities[randomCityIndex];

		return res;
	}
}


public class Program
{
	public static void Main()
	{
		Random r = new Random();
		int n = int.Parse(Console.ReadLine());

		for (int i = 0;i < n;i++)
		{
			Message m = new Message();
			Console.WriteLine(m.generateText(r));
		}
	}
}
