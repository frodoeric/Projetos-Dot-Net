using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaDeInts = new MinhaLista<int>();
            listaDeInts.Add(1);
            listaDeInts.Add(2);
            listaDeInts.Remove(1);

            var i = listaDeInts[0];
        }
    }

    public class MinhaLista<T> where T : struct
    {
        private readonly List<T> _listaInterna;

        public MinhaLista()
        {
            _listaInterna = new List<T>();
        }

        public void Add(T item)
        {
            _listaInterna.Add(item);
        }

        public void Remove(T item)
        {
            _listaInterna.Remove(item);
        }

        public T this[int index]
        {
            get { return _listaInterna[index]; }
            set { _listaInterna[index] = value; }
        }
    }
}
