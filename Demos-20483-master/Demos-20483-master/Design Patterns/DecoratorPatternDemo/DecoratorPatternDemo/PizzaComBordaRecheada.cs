namespace DecoratorPatternDemo
{
	public class PizzaComBordaRecheada : AdicionaisDecoratorBase
	{
		public override string Descricao
		{
			get { return Pizza.Descricao + ", Borda recheada"; }
		}

		public override double Custo
		{
			get { return 4.0 + Pizza.Custo; }
		}

		public PizzaComBordaRecheada(Pizza pizza) : base(pizza)
		{
		}
	}
}