namespace DecoratorPatternDemo
{
	public class PizzaComMassaGrossa :AdicionaisDecoratorBase
	{
		public override string Descricao
		{
			get { return Pizza.Descricao + ", Massa grossa"; }
		}

		public override double Custo
		{
			get { return 3.0 + Pizza.Custo; }
		}

		public PizzaComMassaGrossa(Pizza pizza) : base(pizza)
		{
		}
	}
}