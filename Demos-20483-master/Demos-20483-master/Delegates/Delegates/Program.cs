using System;
using System.Threading;

namespace Delegates
{
    class Program
    {
        delegate void Callback();

        static void Main(string[] args)
        {
            var meuCallback = new Callback(Bar);

            // Eu vou chamar o método Foo(), este, por sua vez, vai chamar o método Bar() quando terminar
            Foo(meuCallback);
        }

        static void Foo(Callback callback)
        {
            Console.WriteLine("Fazer alguma coisa importante e demorada aqui");
            Thread.Sleep(5000);

            Console.WriteLine("E quando terminar, chamar o callback");
            callback();
        }

        private static void Bar()
        {
            // Fazer mais alguma coisa importante aqui
            Console.WriteLine("Callback executado");
            Console.ReadLine();
        }

    }
}
