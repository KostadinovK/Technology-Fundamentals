using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApp.Models
{
	public class Calculator
	{
		public decimal LeftOperand { get; set; }
		public string Operator { get; set; }
		public decimal RightOperand { get; set; }
		public decimal Result { get; set; }

		public Calculator()
		{
			this.Result = 0;
		}

		public Calculator(decimal leftOperand, string oper, decimal rightOperand)
		{
			this.LeftOperand = leftOperand;
			this.RightOperand = rightOperand;
			this.Operator = oper;
			this.Result = 0;
		}

		public void CalculateResult()
		{
			switch (this.Operator)
			{
				case "+":
					this.Result = this.LeftOperand + this.RightOperand;
					break;
				case "-":
					this.Result = this.LeftOperand - this.RightOperand;
					break;
				case "*":
					this.Result = this.LeftOperand * this.RightOperand;
					break;
				case "/":
					if (this.RightOperand != 0)
					{
						this.Result = this.LeftOperand / this.RightOperand;
						
					}
					break;

			}
		}
	}
}
