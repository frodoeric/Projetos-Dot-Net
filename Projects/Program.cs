using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //throw new Exception("Erro no Error");

                int x = 1;
                int y = 0;

                Adicionar(0, 0);


                int z = x / y;


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Arquivo não encontrado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.Read();
            }

        }

        static int Adicionar(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                throw new ArgumentException("x é maior que zero ou y é maior que zero");

            }
            return x + y;
        }

    }

}
