﻿using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		string regex = @"(\b|/s|^)(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
		string dates = Console.ReadLine();

		MatchCollection matchedDates = Regex.Matches(dates, regex);

		foreach (Match date in matchedDates)
		{
			string day = date.Groups["day"].Value;
			string month = date.Groups["month"].Value;
			string year = date.Groups["year"].Value;

			Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
			
		}
	}
}
