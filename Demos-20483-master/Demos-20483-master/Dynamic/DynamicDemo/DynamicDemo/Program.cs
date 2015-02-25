using System;
using IronPython.Hosting;

namespace DynamicDemo
{
	class Program
	{
		static void Main()
		{
			var engine = Python.CreateEngine();
			var scope = engine.CreateScope();

			engine.ExecuteFile("Add.py", scope);

			dynamic add = scope.GetVariable("Add");

			dynamic result = add(2, 2);

			Console.WriteLine("Segundo o Python, 2 + 2 é igual a: " + result);
			Console.ReadLine();
		}
	}
}
