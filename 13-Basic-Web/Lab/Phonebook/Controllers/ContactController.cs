using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Phonebook.Data;
using Phonebook.Data.Models;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
	    [HttpPost]
	    public IActionResult Create(Contact contact)
	    {
		    if (IsValidContact(contact))
		    {
			    DataAccess.contacts.Add(contact);
			}
		    else
		    {
				throw new ArgumentException("Invalid contact!");
		    }

		    return RedirectToAction("Index","Home");
	    }

	    private bool IsValidContact(Contact contact)
	    {
			Regex validName = new Regex(@"\b[A-Z][a-z]*\s?[A-Z]?[a-z0-9]*\b");
			Regex validNumber = new Regex(@"\b\d{3}\s?\d{3}\s?\d{4}\b");

		    Match nameMatch = validName.Match(contact.Name);
		    Match numberMatch = validNumber.Match(contact.Number);
		    if (nameMatch.Success && numberMatch.Success)
		    {
			    return true;
		    }

		    return false;
	    }
    }
}