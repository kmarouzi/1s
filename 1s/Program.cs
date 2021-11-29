using System;

namespace mostatil
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("ars: ");
			string ars = Console.ReadLine();
			Console.Write("toul: ");
			string toul = Console.ReadLine();
			float mohit = (float.Parse(ars) + float.Parse(toul)) * 2;
			float masohat = float.Parse(ars) * float.Parse(toul);
			Console.WriteLine("mohit: " + mohit);
			Console.WriteLine("masohat: " + masohat);
			Console.ReadKey();
		}
	}
}
