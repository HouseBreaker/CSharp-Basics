using System;

	class Divide
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());

			if ((n % 7 == 0) && (n % 5 == 0))
			{
				Console.WriteLine("{0} is divisible by 7 and 5", n);
			}
			else
			{
				Console.WriteLine("{0} is not divisible by 7 and 5", n);
			}
		}
	}
