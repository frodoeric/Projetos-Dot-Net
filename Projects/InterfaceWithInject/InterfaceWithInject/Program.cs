using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceWithInject
{
    class Program
    {
        static void Main(string[] args)
        {
            var motor = new Motor(new EnergiaSolar());
            motor.Rodar();

            var outroMotor = new Motor(new EnergiaEolica());
            outroMotor.Rodar();

            Console.Read();
        }
    }

    interface IFonteDeEnergia
    {
        bool FornecerEnergia();
    }

    class EnergiaSolar : IFonteDeEnergia
    {
        private int energia = 5;

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

    class EnergiaEolica : IFonteDeEnergia
    {
        private int energia = 3;

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

    class Motor
    {
        private IFonteDeEnergia _fonteDeEnergia;

        public Motor(IFonteDeEnergia fonteDeEnergia)
        {
            _fonteDeEnergia = fonteDeEnergia;
        }

        public void Rodar()
        {
            while (_fonteDeEnergia.FornecerEnergia())
	        {
            Console.WriteLine("Rodando...");
	         
	        }
            Console.WriteLine("O motor parou");
        }
    }

}
