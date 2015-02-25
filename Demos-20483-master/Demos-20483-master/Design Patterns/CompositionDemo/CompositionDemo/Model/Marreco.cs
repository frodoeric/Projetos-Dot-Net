using CompositionDemo.Behaviors;

namespace CompositionDemo.Model
{
	public class Marreco : Pato
	{
		public Marreco()
		{
			VoarBehavior = new VoarBehaviorComAsasBehavior();
			QuackBehavior =  new QuackBehaviorBehavior();
		}
	}
}