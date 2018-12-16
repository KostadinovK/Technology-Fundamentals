using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{

	private static bool IsValidArtist(string artist)
	{
		if (artist[0] < 'A' || artist[0] > 'Z')
		{
			return false;
		}

		for (int i = 1;i < artist.Length;i++)
		{
			if (artist[i] == ' ' || artist[i] == '\'' || (artist[i] >= 'a' && artist[i] <= 'z'))
			{
				continue;
			}
			
			return false;
		}

		return true;
	}

	private static bool IsValidSong(string song)
	{
		for (int i = 0;i < song.Length;i++)
		{
			if (song[i] == ' ' || (song[i] >= 'A' && song[i] <= 'Z'))
			{
				continue;
			}

			return false;
		}

		return true;
	}

	private static void ValidateLetter(ref char letter,int oldCharCode)
	{
		int diff = 0;
		int newLetterCode = 0;
		char oldChar = (char) oldCharCode;
		if (letter > 'Z' && oldChar <= 'Z' && oldChar >= 'A')
		{
			diff = letter - 'Z';
			newLetterCode = 'A' + diff-1;
			letter = (char) newLetterCode;
		}
		else if(letter > 'z')
		{
			diff = letter - 'z';
			newLetterCode = 'a' + diff - 1;
			letter = (char)newLetterCode;
		}


	}

	public static void Main()
	{

		string input = Console.ReadLine();
		while (input != "end")
		{
			List<string> args = input.Split(":").ToList();
			string artist = args[0];
			string song = args[1];
			if (IsValidArtist(artist) && IsValidSong(song))
			{
				int encryptKey = artist.Length;
				StringBuilder sb = new StringBuilder();
				for (int i = 0;i < input.Length;i++)
				{
					if (input[i] == ':' || input[i] == '\'' || input[i] == ' ')
					{
						if (input[i] == ':')
						{
							sb.Append("@");
						}
						else
						{
							sb.Append(input[i]);
						}

						continue;
					}

					int newLetterCode = encryptKey + input[i];
					char newLetter = (char)newLetterCode;
					
					ValidateLetter(ref newLetter, newLetter - encryptKey);


					sb.Append(newLetter);
				}

				Console.WriteLine($"Successful encryption: {sb}");
			}
			else
			{
				Console.WriteLine("Invalid input!");
			}

			input = Console.ReadLine();
		}
	}
}
