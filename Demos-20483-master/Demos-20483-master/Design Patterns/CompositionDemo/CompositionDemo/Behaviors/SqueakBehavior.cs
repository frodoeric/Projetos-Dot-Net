using System;
using CompositionDemo.Interfaces;

namespace CompositionDemo.Behaviors
{
	public class Squeak :IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Squeak!");
		}
	}
}