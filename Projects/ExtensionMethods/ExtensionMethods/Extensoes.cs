using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Extensoes
    {
        public static string Capitalizar(this string texto)
        {
            var primeiraLetra = texto.Substring(0, 1);
            primeiraLetra = primeiraLetra.ToUpper();
            return primeiraLetra + texto.Substring(1, texto.Length - 1).ToLower();
        }
    }
}
