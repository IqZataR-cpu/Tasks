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
                // Когда переносишь строки пробел между ними лучше оставлять в конце, а не в начале строки.
                Console.WriteLine("Умножение матриц не возможно, так как количество столбцов"+
                         "  матрицы А не равно количеству строк в матрице В");
            }          
        }

        // Старайся делать названия параметров не под частный случай, а под все подобные случаи.
        // В целом слово number здесь не нужно, можно просто columnsMatrixA(или columnsFirstMatrix)...
        // Можно даже просто columns и rows.
        static bool canMultiplicate (int numberOfColumnsMatrixA, int numberOfRowsMatrixB)
        {
            // Эта переменная здесь не нужна, смысл и так понятен.
            // Для этого мы и создали функцию canMultiplicate
            bool isEqualsTwoNumbers = numberOfColumnsMatrixA == numberOfRowsMatrixB;

            // Это можно заменить одной строчкой return isEqualsTwoNumbers; 
            // Смысл сохраниться оно вернет либо false, либо true =)
            if (isEqualsTwoNumbers)
            {
                return true;
            }

            return false;
            
            // Таким образом этот метод можно сократить до одной строки
            // return numberOfColumnsMatrixA == numberOfRowsMatrixB;
        }

        // Здесь не следовало передавать результирующую матрицу,
        // стоило просто создать ее внутри метода и вернуть ее
        // (массив - ссылочный тип, так что проблем с производительностью нет)
        // Ты бы вернул просто ссылку на массив.
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

        // numberOfRows и Columns можно получить с помощью Length.
        // Та же проблема с результирующей матрицей.
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
        
        // Можно просто передавать matrix, по названию метода и так понятно, что она будет распечатана,
        // Ширину и длину матрицы можно взять прямиком из массива. Length
        // Еще можешь попытаться сделать метод универсальным для любой мерности,
        // то есть если была бы 3х, 4х... размерная матрица.
        static void PrintMatrix (int[,] printedMatrix, int numberOfRows, int numberOfColumns)
        {
            Console.WriteLine("\n Матрица:");

            for (int i = 0; i <= numberOfRows - 1; i++)
            {
                // Я бы лучше после цикла сделал перенос строки, а не перед.
                Console.WriteLine();

                for (int j = 0; j <= numberOfColumns - 1; j++)
                {
                    Console.Write($"{printedMatrix[i, j]} ");
                }
            }
        }
    }
}
