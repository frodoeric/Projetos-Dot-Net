using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Entre um número entre 0 e 9: ");
			var entrada = Console.ReadLine();

			switch (entrada)
			{
				case "0":
					Console.WriteLine("Digitou 0");
					break;
				case "1":
					Console.WriteLine("Digitou 1");
					break;
				case "2":
					Console.WriteLine("Digitou 2");
					break;
				case "3":
					Console.WriteLine("Digitou 3");
					break;
				case "4":
					Console.WriteLine("Digitou 4");
					break;
				case "5":
					Console.WriteLine("Digitou 5");
					break;
				case "6":
					Console.WriteLine("Digitou 6");
					break;
				case "7":
					Console.WriteLine("Digitou 7");
					break;
				case "8":
					Console.WriteLine("Digitou 8");
					break;
				case "9":
					Console.WriteLine("Digitou 9");
					break;
				default:
					Console.WriteLine("Número inválido");
					break;
			}

			Console.ReadLine();
		}
	}
}
