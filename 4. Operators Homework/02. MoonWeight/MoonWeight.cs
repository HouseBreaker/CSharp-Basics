using System;

	class MoonWeight
	{
		static void Main()
		{
			double weight = double.Parse(Console.ReadLine());

			Console.WriteLine("A person with a weight of {0}kg will be {1}kg on the moon!", weight, (weight * 17 / 100));
		}
	}

