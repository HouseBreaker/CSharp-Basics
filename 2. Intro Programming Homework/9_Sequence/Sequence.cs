using System;

	class Sequence
	{
		static void Main()
		{
			int max = 10;
			for (int i = 2; i <= max; i++)
			{
				if (i != max)
				{
					if (i % 2 == 0)
					{
						Console.Write("{0}, ", i);
					}

					else
					{
						Console.Write("{0}, ", -i);
					}
				}

				else
				{
					Console.WriteLine(i);
				}

			}
		}
	}

