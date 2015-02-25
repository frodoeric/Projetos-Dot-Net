using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um array comum
            int[] array1 = new int[10];

            // Acessando o terceiro item do array
            int item3 = array1[2];


            
            // Jagged array com 3 linhas
            // Um jagged array é um array de arrays
            int[][] jaggedArray = new int[3][];

            // Criar um array no jagged array
            jaggedArray[0] = new int[2];
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 2;

            // Definir a segunda linha, inicializada como 0.
            jaggedArray[1] = new int[1];

            // Definir a terceira linha, usando um array initializer.
            jaggedArray[2] = new int[3] { 3, 4, 5 };

            // Imprime todos os elementos do jagged array.
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] innerArray = jaggedArray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.Write(innerArray[a] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
