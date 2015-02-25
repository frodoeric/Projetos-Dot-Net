using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace UnobservedTaskExceptionDemo
{
	class Program
	{
		static void Main()
		{
			TaskScheduler.UnobservedTaskException += (sender, e) =>
			{
				foreach (var ex in (e.Exception).InnerExceptions)
				{
					Console.WriteLine("Ocorreu um erro: {0}", ex.Message);
				}
				e.SetObserved();
			};

			Task.Run(() =>
			{
				throw new NullReferenceException();
			});

			Thread.Sleep(5000);
			GC.WaitForPendingFinalizers();
			GC.Collect();
			Console.WriteLine("Fim");
			Console.ReadLine();

				
			// No .NET 4.0 as UnobservedTaskExceptions são por padrão lançadas e
			// derrubam a aplicação se não forem tratadas, já no .NET 4.5 elas são por padrão ignoradas.
			//
			// O detalhe é que, se você tiver o .NET 4.5 instalado na máquina, essas exceções vão ser também ignoradas
			// mesmo no .NET 4.0, a não ser que o valor abaixo seja definido como "true" 
			// no arquivo app.config ou web.config
			//
			// <runtime>
			//	 <ThrowUnobservedTaskExceptions enabled="true" />
			// </runtime>
		}
	}
}
