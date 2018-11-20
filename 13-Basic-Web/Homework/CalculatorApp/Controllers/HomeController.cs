using CalculatorApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

		[HttpPost]
	    public IActionResult Calculate(Calculator calculator)
		{
			calculator.CalculateResult();

			if (calculator.RightOperand == 0 && calculator.Operator == "/")
			{
				TempData["Error"] = "Can't divide by Zero!";
			}
			else
			{
				OperationsData.Operations.Add(calculator);
			}
			
			return RedirectToAction("Index",calculator);
		}

	    public IActionResult History()
	    {
		    return View(OperationsData.Operations);
	    }

    }
}
