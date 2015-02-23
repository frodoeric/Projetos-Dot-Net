using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Coisa : IDisposable//para fechar as conexões automágicamente
    {
        private Stream strem;

        public void Dispose()
        {
            strem.Dispose();
        }
    }
}
