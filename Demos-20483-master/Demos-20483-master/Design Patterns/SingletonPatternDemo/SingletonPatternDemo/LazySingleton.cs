using System;

namespace SingletonPatternDemo
{
	public sealed class LazySingleton
	{
		private static readonly Lazy<LazySingleton> LazyInstance =
			new Lazy<LazySingleton>(() => new LazySingleton(), isThreadSafe: true);

		public static LazySingleton Instance { get { return LazyInstance.Value; } }

		private LazySingleton()
		{
		}

		// Se você chamar este método, o singleton NÃO será instanciado
		public static void DoSomething()
		{

		}

		public void SayHello()
		{
			Console.WriteLine("Hello");
		}
	}
}