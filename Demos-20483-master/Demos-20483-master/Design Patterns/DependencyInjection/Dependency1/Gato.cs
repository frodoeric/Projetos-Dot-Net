using System;
using ConsoleApplication1;

namespace Dependency1
{
    public class Gato : IFalante
    {
        public void DigaOla()
        {
            Console.WriteLine("Miau");
        }
    }
}
