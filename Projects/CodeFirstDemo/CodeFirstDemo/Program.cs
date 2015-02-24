using CodeFirstDemo.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ClientesContext();

            var clientes = from c in context.Clientes
                           //where c.Nome.StartsWith("A")
                           //join p in context.Pedidos on c.ClienteId equals p.ClienteId
                           //group c by c.Idade into cIdade
                           where c.Nome == "Anacleto"
                           orderby c.ClienteId descending
                           //select c).First();
                           //select cIdade;
                           select c;
                           //select new { c.Nome, p.Descricao };//objeto anônimo

            //var clientes2 = context
            //    .Clientes
            //    .First(c => c.Nome == "Anacleto");

            var umCliente = clientes.First();

            Console.WriteLine(umCliente.Nome);
            
            
            
            
            
            
            
           

           // var grupo = clientes.ToList();

            //foreach (var cliente in clientes)
            //{
            //    Console.WriteLine("{0}, {1}", cliente.Nome, cliente.Descricao);
            //}

            //foreach (var cliente in context.Clientes)
            //{
            //    Console.WriteLine("{0}, {1}, {2}", cliente.Nome, cliente.Sobrenome, cliente.Idade);
            //}

            //var novoCliente = new Cliente
            //{
            //    Nome = "Fulano",
            //    Sobrenome = "Silva",
            //    Idade = 20
            //};

            //context.Clientes.Add(novoCliente);

            //context.SaveChanges();//para gravar as auterações

            //var primeiroCliente = context.Clientes.First();
            //primeiroCliente.Nome = "Anacleto";
            //context.Entry(primeiroCliente).State = EntityState.Modified;
            //context.SaveChanges();
        }
    }
}
