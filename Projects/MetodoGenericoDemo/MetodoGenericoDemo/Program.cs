using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoGenericoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var produtos = Repositorio.Obter<Produto>();
        }
    }

    static class Repositorio
    {
        public static List<T> Obter<T>() where T : class //especificando o tipo tem q ser uma classe
        {
            //consultar base de dados e retornar...

            return new List<T>();
        }
    }
}
