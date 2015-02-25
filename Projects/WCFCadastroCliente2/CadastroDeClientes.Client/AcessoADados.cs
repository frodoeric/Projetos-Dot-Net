using CadastroDeClientes.Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeClientes.Client
{
    public class AcessoADados
    {
        private ClientesContext context;

        public AcessoADados()
        {
            var uri = new Uri("http://localhost:1669/ClienteService.svc/");
            context = new ClientesContext(uri);
        }

        public IEnumerable<Cliente> ObterClientes()
        {
            return context.Clientes.ToList();
        }

        public void AdicionarCliente(Cliente cliente)
        {
            context.AddToClientes(cliente);
            context.SaveChanges();
            
        }

        public void ExcluirCliente(Cliente cliente)
        {
                context.DeleteObject(cliente);
                context.SaveChanges();
        }

        public void AtualizarCliente(Cliente cliente)
        {
            context.UpdateObject(cliente);
            context.SaveChanges();
        }
    }
}
