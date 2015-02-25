using System.Collections;
using System.Collections.Generic;

namespace Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFoo = new FooCollection<string>();

            foreach (var foo in myFoo)
            {
                
            }
        }
    }

    class FooCollection<T> : IEnumerable<T>, IEnumerable
    {
        readonly List<T> _foos;

        public FooCollection()
        {
            _foos = new List<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T foo in _foos)
            {
                yield return foo;
            }

            // Ou apenas retorne o enumerator
            // return _foos.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
