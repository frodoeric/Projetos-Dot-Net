using CompositionDemo.Behaviors;

namespace CompositionDemo.Model
{
	public class PatoDeBorracha : Pato
	{
		public PatoDeBorracha()
		{
			VoarBehavior = new NaoVoaBehavior();
			QuackBehavior = new Squeak();
		}
	}
}