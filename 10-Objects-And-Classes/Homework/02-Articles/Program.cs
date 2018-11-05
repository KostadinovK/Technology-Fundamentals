using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Article
{
	private string Title { get; set; }
	private string Content { get; set; }
	private string Author { get; set; }

	public Article(string title, string content, string author)
	{
		this.Author = author;
		this.Content = content;
		this.Title = title;
	}

	public void Edit(string newContent)
	{
		this.Content = newContent;
	}

	public void ChangeAuthor(string newAuthor)
	{
		this.Author = newAuthor;
	}

	public void Rename(string newName)
	{
		this.Title = newName;
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
		List<string> tokens = Console.ReadLine().Split(new string[]{", "},StringSplitOptions.None).ToList();

		Article a = new Article(tokens[0],tokens[1],tokens[2]);

		int n = int.Parse(Console.ReadLine());

		for (int i = 0;i < n;i++)
		{
			List<string> args = Console.ReadLine().Split(new string[] {": "}, StringSplitOptions.None).ToList();
			string command = args[0];

			if (command == "Edit")
			{
				a.Edit(args[1]);
			}else if (command == "ChangeAuthor")
			{
				a.ChangeAuthor(args[1]);
			}else if (command == "Rename")
			{
				a.Rename(args[1]);
			}
		}

		Console.WriteLine(a);
	}
}
