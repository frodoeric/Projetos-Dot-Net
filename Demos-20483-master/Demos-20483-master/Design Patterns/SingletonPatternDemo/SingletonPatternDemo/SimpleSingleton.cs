using System;

namespace SingletonPatternDemo
{
	public sealed class SimpleSingleton
	{
		private static readonly SimpleSingleton LazyInstance = new SimpleSingleton();

		// Construtor estático para permitir Lazy Loading
		static SimpleSingleton()
		{
		}

		private SimpleSingleton()
		{
		}

		// Se você chamar este método, o singleton será instanciado, mesmo que
		// a property 'Instance' abaixo ainda não tenha sido acessada
		public static void DoSomething()
		{
			
		}


		public static SimpleSingleton Instance
		{
			get
			{
				return LazyInstance;
			}
		}

		public void SayHello()
		{
			Console.WriteLine("Hello");
		}
	}
}