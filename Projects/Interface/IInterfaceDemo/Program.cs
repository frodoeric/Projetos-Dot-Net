using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    interface IOutra
    {
        //por padrão é pública

        void Falar();
    }

    interface Ifalante
    {
        //por padrão é pública

        void Falar();
    }

    class Pessoa : Ifalante, IOutra
    {
        public void Falar()
        {
            Console.WriteLine("Olá");
        }
    }

    class Cachorro : Ifalante
    {
        public void Falar()
        {
            Console.WriteLine("Au au");
        }
    }

    class Teste : Ifalante
    {
        public void Coisar(Ifalante falante)
        {
            falante.Falar();
        }
    }

}
