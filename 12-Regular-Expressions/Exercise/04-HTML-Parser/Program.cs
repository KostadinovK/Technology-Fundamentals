using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string html = Console.ReadLine();
		Regex titleRegex = new Regex(@"<title>(?<title>[A-Za-z0-9\s._-]+)<\/title>");
		Match m = titleRegex.Match(html);
		string title = "";
		if (m.Success)
		{
			title = m.Groups["title"].Value;
		}

		Console.WriteLine($"Title: {title}\n");
		
	}
}
