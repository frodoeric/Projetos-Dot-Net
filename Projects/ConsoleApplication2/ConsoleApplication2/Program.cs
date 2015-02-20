using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //var watch = new Stopwatch();
            //watch.Start();

            //var stringBuilder = new StringBuilder();

            //for (int i = 0; i < 50000; i++)
            //{
            //    stringBuilder.Append("blá");
            //}



            //string teste = stringBuilder.ToString();

            //watch.Stop();

            //Console.WriteLine("tempo: " + watch.Elapsed);

            //Thread.Sleep(2000);

            //Console.WriteLine("teste");

            //Thread.Sleep(2000);

            //Console.WriteLine("teste");

            //Console.Read();

            var pessoa1 = new Pessoa
            {
                Nome = "Joaquim"
            };

            RH.Contratar(pessoa1, 10000);

            Console.WriteLine("Salario Joaquim: " + pessoa1.Salario);

            Console.Read();


        }

        static class RH
        {
            public static void Contratar(Pessoa pessoa, int salario)
            {
                pessoa.Salario = salario;
                Console.WriteLine("Contratado com o salário de " + pessoa.Salario);
            }
        }

        class Pessoa
        {
            public int Salario { get; set; }

            public static int População { get; private set; }

            private string _nome;

            public string Nome
            {
                get { return _nome; }
                set { _nome = value; }
            }

            public string Sobrenome { get; set; }

            public int Idade { get; set; }

            public Pessoa()
            {
                População++;
            }
            
        }
        
    }
}
