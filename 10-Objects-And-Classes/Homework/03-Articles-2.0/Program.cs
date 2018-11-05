using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Article
{
	public string Title { get; set; }
	public string Content { get; set; }
	public string Author { get; set; }

	public Article(string title, string content, string author)
	{
		this.Author = author;
		this.Content = content;
		this.Title = title;
	}


	public override string ToString()
	{
		return $"{Title} - {Content}: {Author}";
	}
}


public class Program
{
	public static void Main()
	{
		List<Article> articles = new List<Article>();

		int n = int.Parse(Console.ReadLine());
		for (int i = 0;i < n;i++)
		{
			List<string> args = Console.ReadLine().Split(new string[]{", "},StringSplitOptions.None).ToList();
			articles.Add(new Article(args[0],args[1],args[2]));
		}

		string sortBy = Console.ReadLine();
		if (sortBy == "title")
		{
			articles = articles.OrderBy(x => x.Title).ToList();
		}else if (sortBy == "content")
		{
			articles = articles.OrderBy(x => x.Content).ToList();
		}
		else
		{
			articles = articles.OrderBy(x => x.Author).ToList();
		}

		Console.WriteLine(string.Join("\n", articles));
	}
}
