using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo3
{
    public delegate void MyEventHandler(string text);

    class Program
    {
        public static event MyEventHandler DigaOlah;

        

        static void Main(string[] args)
        {
            //está se inscrevendo.
            DigaOlah += ExibirMensagem;
            DigaOlah += Program_DigaOla;
            //quando for invocado o evento, vai chamar o evento.

            //Desescrevendo o evento
            DigaOlah -= ExibirMensagem;

            //Invocando o evento
            //DigaOlah.Invoke("Fulano");

            OnDigaOlah("Fulano");

        }

        public static void OnDigaOlah(string nome)
        {
            var handler = DigaOlah;
            if (handler != null)
            {
                handler.Invoke(nome);
            }
        }

        private static void Program_DigaOla(string text)
        {
            throw new NotImplementedException();
        }

        public static void ExibirMensagem(string nome)
        {
            Console.WriteLine("Olá " + nome);
        }

    }
}
