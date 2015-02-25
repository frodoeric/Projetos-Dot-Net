using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Task();
        }

        public static async void Task()
        {
            //GetStringAsync cria uma thread
            var cliente = new HttpClient();
            string result = await cliente.GetStringAsync("http://www.uol.com.br");//recebe uma task de string
            //o método tem que ser async para poder utilizar o await.
            //await não irá bloquear a tarefa
            Console.WriteLine(result);
        }
    }
}
