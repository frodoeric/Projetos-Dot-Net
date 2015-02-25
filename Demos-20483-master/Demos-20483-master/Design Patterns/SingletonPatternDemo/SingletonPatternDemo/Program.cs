using System;

namespace SingletonPatternDemo
{
	class Program
	{
		static void Main()
		{
			var lazySingleton = LazySingleton.Instance;
			lazySingleton.SayHello();

			var simpleSingleton = SimpleSingleton.Instance;
			simpleSingleton.SayHello();

			Console.ReadLine();
		}
	}
}
