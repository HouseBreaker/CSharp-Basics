using System;
using System.Text;
	class IsoscelesTriangle
	{
		static void Main()
		{
			Console.OutputEncoding = new UTF8Encoding();
			char a = (char)169;

			Console.WriteLine("   {0}", a);
			Console.WriteLine("  {0} {0}", a);
			Console.WriteLine(" {0}   {0}", a);
			Console.WriteLine("{0} {0} {0} {0}\n", a);
		}
	}