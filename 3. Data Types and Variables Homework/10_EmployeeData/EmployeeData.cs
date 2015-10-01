using System;

	class EmployeeData
	{
		static void Main()
		{
			string FirstName;
			string LastName;
			byte age;
			bool isMale;
			long selfID;
			uint workID;

			FirstName = "John";
			LastName = "Smith";
			age = 35;
			isMale = true;
			selfID = 8306112507;
			workID = 2756000000;

			Console.WriteLine("First Name: {0}", FirstName);
			Console.WriteLine("Last Name: {0}", LastName);
			Console.WriteLine("Age: {0}", age);
			Console.Write("Gender: ");
			
			if (isMale)
			{
				Console.WriteLine("Male");
			}
			else
			{
				Console.WriteLine("Female");
			}

			Console.WriteLine("Personal ID: {0}", selfID);
			Console.WriteLine("Work ID: {0}", workID);
		}
	}