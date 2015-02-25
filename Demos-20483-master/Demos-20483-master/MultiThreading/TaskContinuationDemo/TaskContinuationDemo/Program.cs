using System;
using System.Threading.Tasks;

namespace TaskContinuationDemo
{
	class Program
	{
		static void Main()
		{
			var firstTask = Task.Run(() => "Hello");
			var secondTask = firstTask.ContinueWith(antecedent =>
						String.Format("{0}, World!", antecedent.Result));

			Console.WriteLine(secondTask.Result);
			Console.ReadLine();
		}
	}
}
