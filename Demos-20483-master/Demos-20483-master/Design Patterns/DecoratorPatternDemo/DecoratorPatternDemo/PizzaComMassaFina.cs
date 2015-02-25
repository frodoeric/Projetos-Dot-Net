namespace DecoratorPatternDemo
{
	public class PizzaComMassaFina : AdicionaisDecoratorBase
	{
		public override string Descricao
		{
			get { return Pizza.Descricao + ", Massa fina"; }
		}

		public override double Custo
		{
			get { return 0.0 + Pizza.Custo; }
		}

		public PizzaComMassaFina(Pizza pizza) : base(pizza)
		{
		}
	}
}