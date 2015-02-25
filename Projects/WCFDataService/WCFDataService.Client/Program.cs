using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFDataService.Client.ServiceReference1;

namespace WCFDataService.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var uri = new Uri("http://localhost:1437/ClientesService.svc/");//por o caminho do servidor
            var context = new ClienteModelContainer(uri);

            foreach (var cliente in context.Clientes)
            {
                Console.WriteLine("{0}, {1}, {2}",
                    cliente.Id,
                    cliente.Nome,
                    cliente.Sobrenome);
                
            }
            Console.Read();
        }
    }
}
