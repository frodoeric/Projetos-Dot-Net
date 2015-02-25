namespace DecoratorPatternDemo
{
	public abstract class AdicionaisDecoratorBase : Pizza
	{
		protected readonly Pizza Pizza;

		public AdicionaisDecoratorBase(Pizza pizza)
		{
			Pizza = pizza;
		}
	}
}