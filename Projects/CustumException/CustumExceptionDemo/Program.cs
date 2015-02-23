using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustumExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            throw new Exception("Deu Pau");
        }
    }

    class MyException : Exception
    {
        public MyException()
            : base()
        {
        }


    }
}
