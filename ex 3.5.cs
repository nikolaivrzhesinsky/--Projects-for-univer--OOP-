using System;

namespace Task3_5
{
	static class Obmennik
	{
		public static void Obmen(ref int a, ref int b)
		{
			(b, a) = (a, b);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			int a = 15;
			int b = 45;

			Console.WriteLine("do");
			Console.WriteLine("a = {0}, b = {1}", a, b);

			Obmennik.Obmen(ref a, ref b);
			Console.WriteLine("posle");
			Console.WriteLine("a = {0}, b = {1}", a, b);
		}
	}
}