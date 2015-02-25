using System.Data.Entity.Migrations;
using CadastroDeClientes.Model;
using CadastroDeClientes.WCF.Model;

namespace CadastroDeClientes.WCF.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<ClientesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ClientesContext context)
        {
			context.Clientes.AddOrUpdate(c=>c.Nome,
				new Cliente { Nome = "Robledo", Sobrenome = "Pazotto" },
				new Cliente { Nome = "Joaquim", Sobrenome = "Silva" },
				new Cliente { Nome = "Fulano", Sobrenome = "de Tal" }
			);
        }
    }
}
