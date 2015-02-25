using System;
using CompositionDemo.Interfaces;

namespace CompositionDemo.Behaviors
{
	public class VoarBehaviorComAsasBehavior : IVoarBehavior
	{
		public void Voar()
		{
			Console.WriteLine("Voando com asas!");
		}
	}
}