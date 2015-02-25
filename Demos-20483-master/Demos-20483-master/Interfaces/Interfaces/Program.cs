using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ICumprimentador p = new Pessoa();
            DigaOla(p);

            ICumprimentador d = new Cachorro();
            DigaOla(d);

            ICumprimentador c = new Gato();
            DigaOla(c);

            Console.ReadLine();
        }

        // Usando a interface eu posso criar um único método para os 3 tipos de objetos
        static void DigaOla(ICumprimentador cumprimentador)
        {
            cumprimentador.Cumprimentar();
        }


        // Se eu não tivesse usado uma interface, teria que criar os 3 métodos abaixo, um para cada tipo de objeto
        static void DigaOlaPessoa(Pessoa pessoa)
        {
            pessoa.Cumprimentar();
        }

        static void DigaOlaCachorro(Cachorro cachorro)
        {
            cachorro.Cumprimentar();
        }

        static void DigaOlaGato(Gato gato)
        {
            gato.Cumprimentar();
        }
    }

    interface ICumprimentador
    {
        void Cumprimentar();
    }

    class Pessoa : ICumprimentador
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Olá!");
        }
    }

    class Cachorro : ICumprimentador
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Au Au!");
        }
    }

    class Gato : ICumprimentador
    {
        public void Cumprimentar()
        {
            Console.WriteLine("Miau!");
        }
    }

}
