using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program {

	public static void Main() {
		
		string username = Console.ReadLine();
		var arr = username.ToCharArray();
		Array.Reverse(arr);
		string pass =  new string(arr);
		string guess = Console.ReadLine();
		int tries = 0;
		bool blocked = false;
			while(guess != pass){
				if(tries > 2){ 
					blocked = true;
					break;
				}
				Console.WriteLine("Incorrect password. Try again.");
				tries++;
				guess = Console.ReadLine();
			}
			if(blocked){
				Console.WriteLine($"User {username} blocked!");
			}else{
				Console.WriteLine($"User {username} logged in.");
			}
			
		}
}
