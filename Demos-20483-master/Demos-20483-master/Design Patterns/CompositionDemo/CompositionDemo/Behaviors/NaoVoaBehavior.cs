using System;
using CompositionDemo.Interfaces;

namespace CompositionDemo.Behaviors
{
	public class NaoVoaBehavior : IVoarBehavior
	{
		public void Voar()
		{
			Console.WriteLine("Continuar no chão");
		}
	}
}