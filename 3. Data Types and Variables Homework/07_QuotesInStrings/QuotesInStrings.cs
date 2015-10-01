using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


	class QuotesInStrings
	{
		static void Main(string[] args)
		{
			string a = "The \"use\" of quotations causes difficulties";
			string b = @"The ""use"" of quotations causes difficulties";

			Console.WriteLine(a);
			Console.WriteLine(b);
		}
	}
