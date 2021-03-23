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
                CompletionMatrix(matrixA, numberOfRowsMatrixA, numberOfColumnsMatrixA);
                PrintMatrix(matrixA, numberOfRowsMatrixA, numberOfColumnsMatrixA);

                CompletionMatrix(matrixB, numberOfRowsMatrixB, numberOfColumnsMatrixB);
                PrintMatrix(matrixB, numberOfRowsMatrixB, numberOfColumnsMatrixB);

                MultiplicateMatrix(matrixC, matrixA, matrixB, numberOfRowsMatrixA, numberOfColumnsMatrixB);
                PrintMatrix(matrixC, numberOfRowsMatrixA, numberOfColumnsMatrixB);
            }
            else
            {
                Console.WriteLine("Умножение матриц не возможно, так как количество столбцов"+
                         "  матрицы А не равно количеству строк в матрице В");
            }          
        }

        static bool canMultiplicate (int numberOfColumnsMatrixA, int numberOfRowsMatrixB)
        {
            bool isEqualsTwoNumbers = numberOfColumnsMatrixA == numberOfRowsMatrixB;

            if (isEqualsTwoNumbers)
            {
                return true;
            }

            return false;
        }

        static int[,] CompletionMatrix(int [,] array, int numberOfRows, int numberOfColumns)
        {
            Random randomNumber = new Random();

            for (int i = 0; i <= numberOfColumns - 1; i++)
            {
                for (int j = 0; j <= numberOfColumns - 1; j++)
                {
                    array[i, j] = randomNumber.Next(10);
                }
            }

            return array;
        }

        static int[,] MultiplicateMatrix (int[,] matrixC, int[,] matrixA, int[,] matrixB, int numberOfRows, int numberOfColumns)
        {
            for (int i = 0; i <= numberOfRows - 1; i++)
            {
                for (int j = 0; j <= numberOfColumns - 1; j++)
                {
                    for (int k = 0; k <= numberOfRows - 1; k++)
                    {
                        matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                    }                  
                }
            }

            return matrixC;
        }

        static void PrintMatrix (int[,] printedMatrix, int numberOfRows, int numberOfColumns)
        {
            Console.WriteLine("\n Матрица:");

            for (int i = 0; i <= numberOfRows - 1; i++)
            {
                Console.WriteLine();

                for (int j = 0; j <= numberOfColumns - 1; j++)
                {
                    Console.Write($"{printedMatrix[i, j]} ");
                }
            }
        }
    }
}
