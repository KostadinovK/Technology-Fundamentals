using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
	public static void Main()
	{
		string filePath = Console.ReadLine();

		while (filePath.IndexOf('\\') != -1)
		{
			int index = filePath.IndexOf('\\');
			filePath = filePath.Remove(0,index+1);
		}

		List<string> res = filePath.Split('.').ToList();
		Console.WriteLine("File name: " + res[0]);
		Console.WriteLine("File extension: " + res[1]);
	}
}
