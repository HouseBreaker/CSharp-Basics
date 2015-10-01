using System;

	class IsThird7
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			int third = n / 100 % 10;
			if (third == 7)
			{
				Console.WriteLine("The third digit of {0} is 7", n);
			}
			else
			{
				Console.WriteLine("No, the third digit is {0}", third);
			}
		}
	}
