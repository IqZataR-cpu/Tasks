using System;

namespace Matrix_Medium_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
             
            Console.Write("Введите количество столбцов в 1 матрице: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк в 1 матрице: ");
            int j = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов во 2 матрице: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк во 2 матрице: ");
            int k = int.Parse(Console.ReadLine());
            int columnFirstMatrix = i;
            int rowFirstMatrix = j;
            int columnSecondMatrix = m;
            int rowSecondMatrix = k;
            int columnThirdMatrix = j;
            int rowThirdMatrix = m;
            int[,] firstMatrix = new int[i, j];
            int[,] secondMatrix = new int[m, k];
            int[,] thirdMatrix = new int[j, m];
            string firstMatrixString = "";
            string secondMatrixString = "";
            string thirdMatrixString = "";

            for (i = 0; i < columnFirstMatrix; i++)
            {
                for (j = 0; j < rowFirstMatrix; j++)
                {
                    firstMatrix[i, j] = rnd.Next(0, 10);
                    firstMatrixString += firstMatrix[i, j].ToString() + " ";
                }
                firstMatrixString += "\n";
            }
            
            for (m = 0; m < columnSecondMatrix; m++)
            {
                for (k = 0; k < rowSecondMatrix; k++)
                {
                    secondMatrix[m, k] = rnd.Next(0, 10);
                    secondMatrixString += secondMatrix[m, k].ToString() + " ";
                }
                secondMatrixString += "\n";
            }

            Console.WriteLine($"Первая матрица: \n{ firstMatrixString }");
            Console.WriteLine($"Вторая матрица: \n{ secondMatrixString }");
            
            for (j = 0, i = 0; j < columnThirdMatrix; j++, i++)
            {
                for (m = 0, k = 0; m < rowThirdMatrix; m++, k++)
                {
                    thirdMatrix[j, m] = firstMatrix[i, j] * secondMatrix[m, k] +
                                        firstMatrix[i, k] * secondMatrix[m, j];
                    thirdMatrixString += thirdMatrix[j, m].ToString() + " ";
                }
                thirdMatrixString += "\n";
            }
            Console.WriteLine($"Третья матрица: \n{ thirdMatrixString }");
        }
    }
}
