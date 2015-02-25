using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ExecutionContextSuppressFlowDemo
{
	class Program
	{
		static void Main()
		{
			CallContext.LogicalSetData("Name", "Robledo");


			// O Thread criado pelo statement abaixo consegue ter acesso ao Context
			// do Main Thread, portanto a chamado CallContext.LogicalGetData("Name")
			// retorna o valor que foi definido acima
			ThreadPool.QueueUserWorkItem(
					state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));


			// O statement abaixo suprime o fluxo do Context do Main Thread para o helper thread
			var controlFlow = ExecutionContext.SuppressFlow();


			// Como o o fluxo do Context foi suprimido na linha acima, na linha a baixo a chamada
			// CallContext.LogicalGetData("Name") não consegue acessar o valor que foi definido
			// na primeira linha do programa. Isto representa um ganho de performance, já que o 
			// Context não precisou ser copiado, mas também pode representar um problema se um 
			// helper thread precisar acessar informações do Context do Main Thread.
			ThreadPool.QueueUserWorkItem(
			state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));

			controlFlow.Undo();

			// A linha de cima reestabeleceu o fluxo do Context do Main Thread para os helper threads,
			// portanto a linha de baixo consegue acessar o valor que foi definido na primeira linha do programa
			ThreadPool.QueueUserWorkItem(
					state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));


			Console.ReadLine();
		}
	}
}
