using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;

namespace Phonebook.Data
{
	public class DataAccess
	{
		public static List<Models.Contact> contacts = new List<Models.Contact>();
	}
}
