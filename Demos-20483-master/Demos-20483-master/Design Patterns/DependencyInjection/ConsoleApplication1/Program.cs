using System;
using System.Collections.Generic;
using Ninject;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(new List<string> {"Dependency1.dll", "Dependency2.dll"});
            IFalante falante = kernel.Get<IFalante>();

            falante.DigaOla();
            Console.ReadLine();
        }
    }
    public interface IFalante
    {
        void DigaOla();
    }
}
