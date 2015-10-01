using System;


class CompanyInfo
{
	static void Main()
		{
			Console.Write("Company name: ");
			string name = Console.ReadLine();
			Console.Write("Company Address: ");
			string address = Console.ReadLine();
			Console.Write("Phone number: ");
			string phone = Console.ReadLine();
			Console.Write("Fax number: ");
			string fax = Console.ReadLine();
			Console.Write("Web site: ");
			string website = Console.ReadLine();
			Console.Write("Manager first name: ");
			string managerFirst = Console.ReadLine();
			Console.Write("Manager last name: ");
			string managerLast = Console.ReadLine();
			Console.Write("Manager age: ");
			string managerAge = Console.ReadLine();
			Console.Write("Manager phone: ");
			string managerPhone = Console.ReadLine();

			
			Console.WriteLine("\n" + name);
			Console.WriteLine("Address: " + address);
			Console.WriteLine("Tel. " + phone);
			Console.WriteLine("Fax: " + fax);
			Console.WriteLine("Website: " + website);
			Console.WriteLine("Manager: {0} {1} (age: {2}, tel.: {3})", managerFirst, managerLast, managerAge, managerPhone);
		}
}
