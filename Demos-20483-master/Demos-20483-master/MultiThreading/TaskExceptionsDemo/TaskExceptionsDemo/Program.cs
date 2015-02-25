using System;
using System.Threading.Tasks;

namespace TaskExceptionsDemo
{
	internal class Program
	{
		private static void Main()
		{
			var task1 = Task.Factory.StartNew(() =>
			{
				throw new MyException("Ocorreu um erro!");
			});

			try
			{
				task1.Wait();
			}
			catch (AggregateException ae)
			{
				foreach (var e in ae.InnerExceptions)
				{
					if (e is MyException)
					{
						Console.WriteLine(e.Message);
					}
					else
					{
						throw;
					}
				}

			}
		}
	}
}
