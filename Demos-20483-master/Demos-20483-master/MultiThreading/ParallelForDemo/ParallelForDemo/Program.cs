using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelForDemo
{
	internal class Program
	{
		private static void MultiplicarMatrizesSequencialmente(double[,] matA, double[,] matB,
			double[,] result)
		{
			int matACols = matA.GetLength(1);
			int matBCols = matB.GetLength(1);
			int matARows = matA.GetLength(0);

			for (int i = 0; i < matARows; i++)
			{
				for (int j = 0; j < matBCols; j++)
				{
					for (int k = 0; k < matACols; k++)
					{
						result[i, j] += matA[i, k] * matB[k, j];
					}
				}
			}
		}

		private static void MultiplicarMatrizesEmParalelo(double[,] matA, double[,] matB, double[,] result)
		{
			int matACols = matA.GetLength(1);
			int matBCols = matB.GetLength(1);
			int matARows = matA.GetLength(0);

			Parallel.For(0, matARows, i =>
			{
				for (int j = 0; j < matBCols; j++)
				{
					double temp = 0;
					for (int k = 0; k < matACols; k++)
					{
						temp += matA[i, k] * matB[k, j];
					}
					result[i, j] = temp;
				}
			});
		}

		#region Não importa para esta demonstração

		private static void Main()
		{
			int colCount = 180;
			int rowCount = 2000;
			int colCount2 = 270;
			double[,] m1 = InitializeMatrix(rowCount, colCount);
			double[,] m2 = InitializeMatrix(colCount, colCount2);
			double[,] result = new double[rowCount, colCount2];

			Console.WriteLine("Executando loop sequencial...");
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();

			MultiplicarMatrizesSequencialmente(m1, m2, result);
			stopwatch.Stop();
			Console.WriteLine("Tempo do loop sequencial em  milisegundos: {0}", stopwatch.ElapsedMilliseconds);

			stopwatch.Reset();
			result = new double[rowCount, colCount2];

			Console.WriteLine("Executando loop paralelo...");
			stopwatch.Start();
			MultiplicarMatrizesEmParalelo(m1, m2, result);
			stopwatch.Stop();
			Console.WriteLine("Tempo do loop paralelo em milisegundos: {0}", stopwatch.ElapsedMilliseconds);

			Console.ReadKey();
		}


		private static double[,] InitializeMatrix(int rows, int cols)
		{
			double[,] matrix = new double[rows, cols];

			Random r = new Random();
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = r.Next(100);
				}
			}
			return matrix;
		}

		#endregion
	}
}
