using System;

namespace MultiplicationMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число строк в матрицы A : ");
            int numberOfRowsMatrixA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов в матрицы A : ");
            int numberOfColumnsMatrixA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число строк в матрицы B : ");
            int numberOfRowsMatrixB = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число столбцов в матрицы B : ");
            int numberOfColumnsMatrixB = Int32.Parse(Console.ReadLine());

            int[,] matrixA = new int[numberOfRowsMatrixA, numberOfColumnsMatrixA];
            int[,] matrixB = new int[numberOfRowsMatrixB, numberOfColumnsMatrixB];
            int[,] matrixC = new int[numberOfRowsMatrixA, numberOfColumnsMatrixB];

            if (canMultiplicate(numberOfColumnsMatrixA, numberOfRowsMatrixB))
            {
                matrixA = CompletionMatrix(numberOfRowsMatrixA, numberOfColumnsMatrixA);
                PrintMatrix(matrixA);

                matrixB = CompletionMatrix(numberOfRowsMatrixB, numberOfColumnsMatrixB);
                PrintMatrix(matrixB);

                matrixC = MultiplicateMatrix( matrixA, matrixB);
                PrintMatrix(matrixC);
            }
            else
            {
                Console.WriteLine("Умножение матриц не возможно, так как количество столбцов "+
                         "матрицы А не равно количеству строк в матрице В");
            }          
        }

        static bool canMultiplicate (int ColumnsMatrixA, int RowsMatrixB)
        {
            return ColumnsMatrixA == RowsMatrixB;
        }

        static int[,] CompletionMatrix(int numberOfRows, int numberOfColumns)
        {
            Random randomNumber = new Random();
            int[,] array = new int[numberOfRows, numberOfColumns];

            for (int i = 0; i <= numberOfRows - 1; i++)
            {
                for (int j = 0; j <= numberOfColumns - 1; j++)
                {
                    array[i, j] = randomNumber.Next(10);
                }
            }

            return array;
        }

        static int[,] MultiplicateMatrix (int[,] matrixA, int[,] matrixB)
        {
            int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

            for (int i = 0; i <= matrixC.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= matrixC.GetLength(1) - 1; j++)
                {
                    for (int k = 0; k <= matrixA.GetLength(1) - 1; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }                  
                }
            }

            return matrixC;
        }
        
        // Можно просто передавать matrix, по названию метода и так понятно, что она будет распечатана,
        // Ширину и длину матрицы можно взять прямиком из массива. Length
        // Еще можешь попытаться сделать метод универсальным для любой мерности,
        // то есть если была бы 3х, 4х... размерная матрица.
        static void PrintMatrix (int[,] matrix)
        {
            Console.WriteLine("\n Матрица:");

            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {             
                for (int j = 0; j <= matrix.GetLength(1) - 1; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
