using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using CadastroDeClientes.Model;

namespace CadastroDeClientes.WCF
{
	[ServiceContract]
	public interface IClientesService
	{

		[OperationContract]
		IEnumerable<Cliente> GetClientes();

		[OperationContract]
		void AddCliente(Cliente cliente);
	}
}
