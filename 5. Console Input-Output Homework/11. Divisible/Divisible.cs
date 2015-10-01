using System;

class Divisible
{
	static void Main()
	{
		Console.Write("Write a starting number: ");
		int start = int.Parse(Console.ReadLine());

		Console.Write("Write an ending number: ");
		int end = int.Parse(Console.ReadLine());

		Console.Write("Write the dividing number: ");
		int p = int.Parse(Console.ReadLine());


		while ((p == 0) && (end > start)){
			Console.Write("Invalid input! Please enter a number other than 0: ");
			p = int.Parse(Console.ReadLine());
		}

		string result = "";

		for (int i = start; i <= end; i++)
		{
			if (i % p == 0)
			{
					result+=(i + ", ");
			}
		}

		Console.WriteLine("s" + result + "s");
		//Console.WriteLine(result.Remove(result.LastIndexOf(','), 2));
	}
}