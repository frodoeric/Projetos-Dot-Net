using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {

        public delegate int Calcular(int x, int y);
        //delegate ponteiro de função
        //para qualquer lugar que usa dios parâmetros inteiros de entrada e um de saída.

        static void Main(string[] args)
        {
            //usando a função como referência
            Calcular add = new Calcular(Adicionar);
            Calcular mult = new Calcular(Multiplicar);
            var resultado1 = Processar(add);
            var resultado2 = Processar(mult);
            //var resultado = add(2, 2);

            //Calcular mult = new Calcular(Multiplicar);
            //var resultado2 = mult(2, 2);
        }

        static int Adicionar(int x, int y)
        {
            return x + y;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Processar(Calcular calc)
        {
            return calc(3, 3);
        }
    }
}
