using System;

class OddEven
{
	static void Main()
	{
		string input = Console.ReadLine();

		string[] preconversion = input.Split(' ');
		int[] numbers = new int[preconversion.Length];

		int oddproduct = 1, evenproduct = 1;
		for (int i = 0; i < preconversion.Length; i++)
		{
			numbers[i] = int.Parse(preconversion[i]);
		}

		for (int i = 1; i < numbers.Length; i+= 2)
		{
			evenproduct *= numbers[i];
		}

		for (int i = 0; i < numbers.Length; i+=2)
		{
			oddproduct *= numbers[i];
		}

		if (evenproduct == oddproduct)
		{
			Console.WriteLine("Yes");
			Console.WriteLine("Product = " + evenproduct);
		}
		else
		{
			Console.WriteLine("No");
			Console.WriteLine("\nEven Product: " + evenproduct);
			Console.WriteLine("Odd Product: " + oddproduct);
		}
	}
}