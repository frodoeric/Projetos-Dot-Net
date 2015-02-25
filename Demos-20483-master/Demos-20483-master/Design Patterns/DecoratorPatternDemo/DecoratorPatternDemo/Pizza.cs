namespace DecoratorPatternDemo
{
	public abstract class Pizza
	{
		public abstract string Descricao { get; }
		public virtual double Custo
		{
			get { return 0.0; }
		}
	}
}