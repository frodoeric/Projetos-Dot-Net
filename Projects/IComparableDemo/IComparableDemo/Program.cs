using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ArrayList();
            lista.Add(new Pessoa { Nome = "Fulano" });
            lista.Add(new Pessoa { Nome = "Sicrano" });
            lista.Add(new Pessoa { Nome = "Beltrano" });

            lista.Sort();//para utilizar o Sorte precisa implementar a interface IComparable
        }
    }

    class Pessoa : IComparable
    {
        public string Nome { get; set; }

        public int CompareTo(object obj)
        {
            var pessoa = (Pessoa) obj;
            return this.Nome.CompareTo(pessoa.Nome);

        }
    }
}
