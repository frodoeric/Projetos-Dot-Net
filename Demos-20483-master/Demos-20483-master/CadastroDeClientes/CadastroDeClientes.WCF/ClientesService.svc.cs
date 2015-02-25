using System.Collections.Generic;
using System.Linq;
using CadastroDeClientes.Model;
using CadastroDeClientes.WCF.Model;

namespace CadastroDeClientes.WCF
{
	public class ClientestService : IClientesService
	{
		public IEnumerable<Cliente> GetClientes()
		{
			using (var context = new ClientesContext())
			{
				return context.Clientes.ToList();
			}
		}
		public void AddCliente(Cliente cliente)
		{
			using (var context = new ClientesContext())
			{
				context.Clientes.Add(cliente);
				context.SaveChanges();
			}
		}
	}
}
