using System;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace ParallelInvokeDemo
{
	class Program
	{
		static void Main()
		{
			var stopwatch = new Stopwatch();
			stopwatch.Start();

			Parallel.Invoke(() => DownloadSite("http://pazotto.com"),
							() => DownloadSite("http://microsoft.com"),
							() => DownloadSite("http://ibm.com"));

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
