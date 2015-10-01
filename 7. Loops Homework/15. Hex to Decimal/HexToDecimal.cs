using System;
using System.Linq;

class HexToDecimal
{
	static void Main()
	{
		string input = Console.ReadLine().ToUpper();
		input = new string(input.Reverse().ToArray());
		int[] output = new int[input.Length];

		for (int i = 0; i < input.Length; i++)
		{
			switch (input[i])
			{
				default: output[i] = input[i]; break;
				case 'A': output[i] = 10 ; break;
				case 'B': output[i] = 11; break;
				case 'C': output[i] = 12; break;
				case 'D': output[i] = 13; break;
				case 'E': output[i] = 14; break;
				case 'F': output[i] = 15; break;
			}
			
		}
		

		double result = 0;
		for (int i = 0; i < input.Length; i++)
		{
			result += (output[i]) * powerof(16, i);
		}
		Console.WriteLine(result);
		
	}

	static double powerof(double input, int up)
	{
		double initial = input;

		if (up > 0 || up < 0)
		{
			for (int i = 1; i < Math.Abs(up); i++)
			{
				input *= initial;
			}
			if (up < 0)
			{

				input = 1 / input;
			}
		}
		else
		{
			input = 1;
		}

		return input;
	}
	//doesn't really work correctly a lot of the time...
}
