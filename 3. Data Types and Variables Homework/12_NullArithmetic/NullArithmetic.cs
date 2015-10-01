using System;

	class NullArithmetic
	{
		static void Main()
		{
			int? a = null;
			double? b = null;

			Console.WriteLine("{0}, {1}", a,b);

			a = a + null;
			b = b + null;
			
			Console.WriteLine("{0}, {1}", a, b);

			a = a + 3;
			b = b + 4.2;

			Console.WriteLine("{0}, {1}", a, b);
		}
	}
