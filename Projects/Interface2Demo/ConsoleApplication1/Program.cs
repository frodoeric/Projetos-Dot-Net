using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Motor
    {
        private FonteDeEnergia _fonteDeEnergia = new FonteDeEnergia();

        public void Rodar()
        {
            while (_fonteDeEnergia.FornecerEnergia())
            {
                Console.WriteLine("Rodando...");
            }
            Console.WriteLine("O motor parou");
        }
    }

    class FonteDeEnergia
    {
        public int energia = 10;

        public bool FornecerEnergia()
        {
            if (energia > 0)
            {
                energia--;
                return true;
            }
            return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var motor = new Motor();
            motor.Rodar();
            Console.Read();
        }
    }
}
