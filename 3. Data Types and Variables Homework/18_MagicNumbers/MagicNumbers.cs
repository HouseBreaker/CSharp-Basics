using System;

class MagicNumbers
{
	static void Main()
	{
		int sum = int.Parse(Console.ReadLine());
		int diff = int.Parse(Console.ReadLine());

		int results = 0;
		for (int num1 = 111; num1 <= 777; num1++)
		{
			int num2 = num1 + diff;
			int num3 = num2 + diff;

			if (Allowed(num1) && Allowed(num2) && Allowed(num3) &&
				 num3 <= 777 && (Sum(num1) + Sum(num2)
				+ Sum(num3)) == sum)
			{
				Console.WriteLine("{0}{1}{2}", num1, num2, num3);
				results++;
			}
		}
		if (results == 0)
			Console.WriteLine("No");
	}

	private static bool Allowed(int num)
	{
		string digits = num.ToString();
		foreach (var element in digits)
		{
			if (element < '1' || element > '7')
			{
				return false;
			}
		}
		return true;
	}

	private static int Sum(int num)
	{
		int sum = 0;

		while (num > 0)
		{
			sum += num % 10;
			num = num / 10;
		}
		return sum;
	}
}