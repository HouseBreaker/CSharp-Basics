using System;

class Cards
{
	static void Main()
	{
		char[] thechar = new char[4] { '♣', '♦', '♥', '♠' };
		string[] cards = new string[13];

		for (int i = 0; i <= 9; i++)
		{
			cards[i] = (i+2).ToString();
		}
		cards[9] = "J";
		cards[10] = "Q";
		cards[11] = "K";
		cards[12] = "A";

		for (int i = 0; i <= 12; i++)
		{
			for (int j = 0; j <= 3; j++)
			{
				Console.Write(cards[i] + thechar[j] + " ");
			}
			Console.WriteLine();
		}
	}
}
