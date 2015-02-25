using System;

namespace AdapterPatternDemo
{
	class Client
	{
		static void Main()
		{
			// Sem o uso de um adapter, estamos usando o Adaptee diretamente,
			// mas o resultado não é o que esperamos
			var adaptee = new Adaptee();
			Console.Write("Antes do novo padrão\nLeitura precisa: ");
			Console.WriteLine(adaptee.SpecificRequest(5,3));


			// Aqui estamos usando o Adapter que faz uma adaptação no resultado
			// retornado pelo adaptee
			ITarget adapter = new Adapter();
			Console.WriteLine("\nMovendo para o novo padrão");
			Console.WriteLine(adapter.Request(5));
		}
	}
}
