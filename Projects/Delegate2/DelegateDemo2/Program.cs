using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo2
{
    //public delegate bool Predicado(string text);

    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "banana", "abacate", "maçã", "laranja", "pêra"
            };

            //var predicado = new Predicado(TextoComMaisDoQue5Caracteres);
            //var predicado = new Predicado(text => text.Length > 5);

            //var listaFiltrada = Filtrar(list, predicado);
            var listaFiltrada = Filtrar(list, text => text.Length > 5);//usando expressão lampda

        }

        //public static bool TextoComMaisDoQue5Caracteres(string texto)
        //{
        //    if (texto.Length > 5)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public static List<string> Filtrar(List<string> textos, Predicate<string> predicado)
            //Func é um predicado pré-fabricado Func<string, bool>
            //Action é um predicado pré-fabricado que não retorna nada
            //Predicate recebe uma sting e retorna boll
        {
            List<string> retorno = new List<string>();

            foreach (var texto in textos)
	        {
		         if (predicado(texto))
                 {
                     retorno.Add(texto);
                 }
	        }

            return retorno;
        }
    }
}
