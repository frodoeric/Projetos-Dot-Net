using System;

namespace DecoratorPatternDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Pizza pizza1 = new PizzaCalabreza();
			pizza1 = new PizzaComMassaFina(pizza1);
			pizza1 = new PizzaComBordaRecheada(pizza1);
			Console.WriteLine(pizza1.Descricao);


			Pizza pizza2 = new PizzaMussarela();
			pizza2 = new PizzaComMassaGrossa(pizza2);
			Console.WriteLine(pizza2.Descricao);

			Console.ReadLine();
		}
	}
}
