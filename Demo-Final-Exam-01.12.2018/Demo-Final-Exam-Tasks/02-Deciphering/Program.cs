using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

public class Program
{
	private static bool isValidChar(char c)
	{
		if ((c >= 'd' && c <= 'z') || c == '{' || c == '}' || c == '|' || c == '#')
		{
			return true;
		}

		return false;
	}

	public static void Main()
    {
	    string encryptedText = Console.ReadLine();
	    List<string> wordsToReplace = Console.ReadLine().Split().ToList();


		StringBuilder sb = new StringBuilder();

	    for (int i = 0; i < encryptedText.Length;i++)
	    {
		    if (!isValidChar(encryptedText[i]))
		    {
			    Console.WriteLine("This is not the book you are looking for.");
			    return;
		    }
			int newLetterCode = encryptedText[i] - 3;
		    sb.Append((char) newLetterCode);
	    }

	    string decryptedText = sb.ToString();

	    decryptedText = decryptedText.Replace(wordsToReplace[0], wordsToReplace[1]);

	    Console.WriteLine(decryptedText);
    }
}
