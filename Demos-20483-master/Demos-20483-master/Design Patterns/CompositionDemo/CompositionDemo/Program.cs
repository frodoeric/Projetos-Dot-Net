using CompositionDemo.Model;

namespace CompositionDemo
{
	class Program
	{
		static void Main()
		{
			var marreco = new Marreco();
			marreco.Voar();
			marreco.Quack();

			var patoDeBorracha = new PatoDeBorracha();
			patoDeBorracha.Voar();
			patoDeBorracha.Quack();
		}
	}
}
