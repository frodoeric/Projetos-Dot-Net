namespace DecoratorPatternDemo
{
	public class PizzaCalabreza : Pizza
	{
		public override string Descricao
		{
			get { return "Pizza de Calabreza"; }
		}

		public override double Custo
		{
			get { return 20.0; }
		}
	}
}