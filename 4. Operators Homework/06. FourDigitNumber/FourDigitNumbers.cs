using System;

	class FourDigitNumbers
	{
		static void Main()
		{
			Console.Write("Input a 4 digit number: ");
			int n = int.Parse(Console.ReadLine());

			while ((n < 1000) || (n > 9999))
			{
				Console.Write("Error! The input must be a 4 digit number! Try again: ");
				n = int.Parse(Console.ReadLine());
			}

			int n1 = n / 1000;
			int n2 = (n / 100) % 10;
			int n3 = (n / 10) % 10;
			int n4 = n % 10;

			Console.WriteLine("\nSum: {0}", n1+n2+n3+n4); //sum
			Console.WriteLine("Reversed: {3}{2}{1}{0}", n1,n2,n3,n4);
			Console.WriteLine("Last digit in front: {3}{0}{1}{2}", n1, n2, n3, n4);
			Console.WriteLine("Second and third digits exchanged: {0}{2}{1}{3}", n1, n2, n3, n4);
		}
	}
