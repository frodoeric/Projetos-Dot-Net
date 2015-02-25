using System;
using System.Collections;
using System.Collections.Specialized;

namespace IndexerDemo
{
	class Program
	{
		static void Main()
		{
			var collection = new MyCollection();
			collection[0] = "Hello, ";
			collection[1] = "World";

			Console.WriteLine(collection[0] + collection[1]);
			Console.Read();
		}
	}

	public class MyCollection
	{
		private readonly string[] _arrayInterno = new string[100];

		public string this[int index]
		{
			get { return _arrayInterno[index]; }
			set { _arrayInterno[index] = value; }
		}

	}
}
