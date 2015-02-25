using System;

namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();

            if (nome.Length > 10)
            {
                Console.WriteLine("Seu nome tem mais do que dez letras");
            }
            else if (nome.Length > 7)
            {
                Console.WriteLine("Seu nome tem mais do que sete letras");
            }
            else if (nome.Length > 5)
            {
                Console.WriteLine("Seu nome tem mais do que cinco letras");
            }
            else
            {
                Console.WriteLine("Seu nome é bem curto");
            }

            Console.ReadLine();
        }
    }
}
