namespace DecoratorPatternDemo
{
	public class PizzaPortuguesa :Pizza
	{
		public override string Descricao
		{
			get { return "Pizza Portuguesa"; }
		}

		public override double Custo
		{
			get { return 21.0; }
		}
	}
}