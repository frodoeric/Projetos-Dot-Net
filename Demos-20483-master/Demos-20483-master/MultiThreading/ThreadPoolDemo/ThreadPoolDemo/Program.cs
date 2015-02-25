using System;
using System.Threading;

namespace ThreadPoolDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Criando um novo work item");
			ThreadPool.QueueUserWorkItem(ComputeBoundOperation, 5);

			Console.WriteLine("Main thread: trabalhando aqui...");
			Thread.Sleep(3000); 

			Console.WriteLine("Pressione <Enter> para finalizar...");

			Console.ReadLine();
		}

		private static void ComputeBoundOperation(object state)
		{
			Console.WriteLine("ComputeBoundOperation. state = {0}", state);
			Thread.Sleep(1000);
		}
	}
}
