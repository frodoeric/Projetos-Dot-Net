using CompositionDemo.Interfaces;

namespace CompositionDemo.Model
{
	public abstract class Pato
	{
		protected IVoarBehavior VoarBehavior;
		protected IQuackBehavior QuackBehavior;

		public void Voar()
		{
			VoarBehavior.Voar();
		}

		public void Quack()
		{
			QuackBehavior.Quack();
		}
	}
}