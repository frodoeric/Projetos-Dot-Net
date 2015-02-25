using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task(() => Console.WriteLine("Hello"));
            var task2 = task1.ContinueWith(a => Console.WriteLine(a.Status));
            var task3 = task2.ContinueWith(a => Console.WriteLine(a.Status));//continueWith irá continuar, assim executa em sequência, aguardando terminar a anterior.

            //var task2 = new Task(() => Console.WriteLine("World"));
            //var task3 = Task.Factory.StartNew(() => Console.WriteLine("New"));// executa primeiro
            //var task4 = Task.Run(() => Console.WriteLine("Dinossaur"));// thread pull, reutilizados por outras aplicações (reciclar)

            task1.Start();
            //task2.Start();

            Console.Read();
        }
    }
}
