// Demonstração que mostra a diferença de performance que a classe StringBuilder 
// pode representar em algumas situações

using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			var watch = new Stopwatch();
			watch.Start();

			string teste = "";
			for (int i = 0; i < 50000; i++)
			{
				teste += "Isto é um texto ";
			}

			watch.Stop();
			Console.WriteLine("Tempo usando concatenação de string: " + watch.Elapsed);

			watch.Restart();

			var stringBuilder = new StringBuilder();
			for (int i = 0; i < 50000; i++)
			{
				stringBuilder.Append("Isto é um texto ");
			}
			teste = stringBuilder.ToString();

			watch.Stop();
			Console.WriteLine("Tempo usando StringBuilder: " + watch.Elapsed);
			Console.ReadLine();
		}
	}
}
