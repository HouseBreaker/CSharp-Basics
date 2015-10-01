using System;

	class CheckPrime
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			int k = 0;
			//k is there to track whether there's more than 2 integers divisible 
			//(ie if k is more than 2, it's not a prime.)

			for (int i = 1; i <= n; i++)
			{ if (n % i == 0) 
			{ 
				k++; 
			}
			}

			if (k == 2)
			{
				Console.WriteLine("{0} is a prime number", n);
			}
			else
			{
				Console.WriteLine("{0} is NOT a prime number", n);
			}

		}
	}
