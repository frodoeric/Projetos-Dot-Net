using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComposicaoDemo
{
    class Cachorro
    {
        private readonly Andante _andante; //readonly só pode ser lida e não modificada

        //Construtor
        public Cachorro(Andante andante)
        {
            _andante = andante;
        }

        public void Andar()//delegação
        {
            _andante.Andar();
        }
    }

    class Gato
    {
        private readonly Andante _andante;

        public void Andar()
        {
            _andante.Andar();
        }

    }

    class Andante 
    {
        public void Andar()
        {
            Console.WriteLine("Andando");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
