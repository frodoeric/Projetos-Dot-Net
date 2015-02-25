namespace DecoratorPatternDemo
{
	public class PizzaMussarela : Pizza
	{
		public override string Descricao
		{
			get { return "Pizza de mussarela"; }
		}

		public override double Custo
		{
			get { return 19.0; }
		}
	}
}