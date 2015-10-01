using System;

	class ExchangeVars
	{
		static void Main()
		{
			int a = 5;
			int b = 10;

			int c = a;

			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
			Console.WriteLine("Let's switch them around!\n");


			a = b;
			b = c;
			

			Console.WriteLine("a = {0}", a);
			Console.WriteLine("b = {0}", b);
		}
	}
