using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Model1Container();

            foreach (var cliente in context.Cleintes)
            {
                //{0}place holder "Interpolação de string"
                Console.WriteLine("Nome: {0}, Sobrenome: {1}, Idade: {2}", cliente.Nome, cliente.Sobrenome, cliente.Idade);
            }
        }
    }
}
