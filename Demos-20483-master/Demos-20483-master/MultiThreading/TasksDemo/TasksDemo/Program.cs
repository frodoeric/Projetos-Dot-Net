using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace TasksDemo
{
	class Program
	{
		static void Main()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			var tasks = new[]
			{
				Task.Run(() => DownloadSite("http://pazotto.com")),
				Task.Run(() => DownloadSite("http://microsoft.com")),
				Task.Run(() => DownloadSite("http://ibm.com"))
			};

			Task.WaitAll(tasks);

			stopwatch.Stop();
			Console.WriteLine("Todas as tasks foram concluídas em " + stopwatch.ElapsedMilliseconds + " milisegundos");

			Console.ReadLine();
		}

		private static void DownloadSite(string url)
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Console.WriteLine(url + " iniciou");

			var request = WebRequest.Create(url);
			request.GetResponse();

			stopwatch.Stop();

			Console.WriteLine(url + " terminou em: " + stopwatch.ElapsedMilliseconds + " milisegundos");
		}
	}
}
