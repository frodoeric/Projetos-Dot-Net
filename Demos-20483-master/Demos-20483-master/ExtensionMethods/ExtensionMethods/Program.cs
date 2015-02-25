using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Hoje está chovendo";
            Console.WriteLine(texto.Invert());

            Console.ReadLine();
        }
    }

    public static class Extensions
    {
        public static string Invert(this string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
