using System;

	class Program
	{
		static void Main()
		{
			string isLeap;
			int p_holidays;
			int h_weekendshome;
			int weekendsinyear = 52;
			

			//read stuff from user input
			//Console.Write("Is it a leap year? ");
			isLeap = Console.ReadLine();

			//Console.Write("\nHow many holidays are there in the year? ");
			p_holidays = int.Parse(Console.ReadLine());

			//Console.Write("\nHow many weekends is Joro home? ");
			h_weekendshome = int.Parse(Console.ReadLine());

			int normalweekends = weekendsinyear - h_weekendshome;
			
			double TimesPlayed = 
				p_holidays/2 +
				normalweekends*2/3 +
				h_weekendshome;

			if (isLeap == "t")
			{
				TimesPlayed += 3;
			}

			Console.WriteLine(TimesPlayed);

			//Alternatively,
			//if (isLeap == "t")
			//{
			//	Console.WriteLine("Joro plays football {0} times a year, provided he is home {1} weekends and there are {2} holidays.\nAlso, it's a leap year!", TimesPlayed, h_weekendshome, p_holidays);
			//}
			//else
			//{
			//	Console.WriteLine("Joro plays football {0} times a year, provided he is home {1} weekends and there are {2} holidays.\nIt's not a leap year!", TimesPlayed, h_weekendshome, p_holidays);
			//}
	
		}
	}
