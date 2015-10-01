using System;

class BonusScore
{
	static void Main()
	{
		string input = Console.ReadLine();
		int score = 0;

		//input checking!
		while (!int.TryParse(input, out score))
		{
			Console.WriteLine("Invalid input! Try again!");
			input = Console.ReadLine();
		}

		Console.Write("Score = ");

		if (score <= 0 || score > 9) {
			Console.WriteLine("Invalid score!");
		}
		else if (score >= 1 && score <= 3){
			Console.WriteLine("Score = " + score*10);
		}
		else if (score >= 4 && score <= 6)
		{
			Console.WriteLine("Score = " + score * 100);
		}
		else if (score >= 7 && score <= 9)
		{
			Console.WriteLine("Score = " + score * 1000);
		}
	}
}
