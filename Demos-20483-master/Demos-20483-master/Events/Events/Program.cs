using System;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Classe1();
            c.AcabouDeCarregar += c_AcabouDeCarregar;
            c.Carregar();
        }

        static void c_AcabouDeCarregar(object sender, EventArgs e)
        {
            Console.WriteLine("Evento invocado e ouvido com sucesso!");
            Console.ReadLine();
        }
    }

    public class Classe1
    {
        public void Carregar()
        {
            Task.Delay(3000);
            Console.WriteLine("Acabou de carregar. Invocando o evento agora!");
            OnAcabouDeCarregar();
        }

        protected virtual void OnAcabouDeCarregar()
        {
            EventHandler handler = AcabouDeCarregar;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        public event EventHandler AcabouDeCarregar;
    }
}
