using System;
using CompositionDemo.Interfaces;

namespace CompositionDemo.Behaviors
{
	public class QuackBehaviorBehavior : IQuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("Quack!");
		}
	}
}