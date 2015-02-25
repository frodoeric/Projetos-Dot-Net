using System.Data.Entity;
using CadastroDeClientes.Model;

namespace CadastroDeClientes.WCF.Model
{
	public class ClientesContext : DbContext
	{
		public DbSet<Cliente> Clientes { get; set; }
	}
}