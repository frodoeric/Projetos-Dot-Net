using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic é quando a lista é declarada.

            List<string> lista = new List<string>();
            lista.Add("banana");
            lista.Add("maçã");
            lista.Add("pêra");
            //lista.Add(123);//ocorre erro por ser número

            lista.Remove("banana");

            var fila = new Queue<int>();
            fila.Enqueue(1);
            fila.Enqueue(2);

            var resultado = fila.Dequeue();

            var dicionario = new Dictionary<string, int>();
            dicionario.Add("primeiro", 1);
            dicionario.Add("segundo", 2);

            LinkedList<int> listaLigada = new LinkedList<int>();

            string item = lista[1];//não precia fazer o "cast" (string)lista[1]

            int i = 25;

            object obj = i; //Boxing. É apenas um objeto

            //int x = (short)obj; //Unboxing. Feito o cast . Ocorre o tempo todo quando é feito um list sem ser generic.

            var col = new Mycollection<string>();
            col.Add("banana");

            foreach (var item2 in col)
            {
                Console.WriteLine(item2);
            }

            Console.Read();

        }

        //Classe Genérica
        //Você pode criar sua própria Collection (Array)
        class Mycollection<T> : ICollection<T>
        {
            private List<T> listaInterna;

            public Mycollection()
            {
                listaInterna = new List<T>();
            }

            public void Add(T item)
            {
                listaInterna.Add(item);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return listaInterna.GetEnumerator();
            }



            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                throw new NotImplementedException();
            }


            public void Clear()
            {
                listaInterna.Clear();
            }

            public bool Contains(T item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public int Count
            {
                get { throw new NotImplementedException(); }
            }

            public bool IsReadOnly
            {
                get { throw new NotImplementedException(); }
            }

            public bool Remove(T item)
            {
                throw new NotImplementedException();
            }
        }
    }
}
