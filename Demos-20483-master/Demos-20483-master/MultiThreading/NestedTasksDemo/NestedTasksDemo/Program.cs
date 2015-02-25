using System;
using System.Threading;
using System.Threading.Tasks;

namespace NestedTasksDemo
{
	class Program
	{
		static void Main(string[] args)
		{

			var pai = Task.Factory.StartNew(() =>
			{
				Console.WriteLine("Task pai iniciando…");
				var filho = Task.Factory.StartNew(() =>
				{
					Console.WriteLine("Task filho iniciando…");
					Thread.SpinWait(500000);
					Console.WriteLine("Task filho completando…");
				}, TaskCreationOptions.AttachedToParent);
			});

			pai.Wait();
			Console.WriteLine("Task pai completado.");
			Console.ReadLine();
		}
	}
}
