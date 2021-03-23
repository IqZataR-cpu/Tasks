using System;

namespace Matrix_Medium_1
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
             
            Console.Write("Введите количество столбцов в матрицах: ");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк в матрицах: ");
            int j = int.Parse(Console.ReadLine());
            int column = i;
            int row = j;
            int[,] firstMatrix = new int[i, j];
            int[,] secondMatrix = new int[i, j];
            int[,] thirdMatrix = new int[i, j];
            string firstMatrixString = "";
            string secondMatrixString = "";

            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    firstMatrix[i, j] = rnd.Next(0, 10);
                    secondMatrix[i, j] = rnd.Next(0, 10);
                    firstMatrixString += firstMatrix[i, j].ToString() + " ";
                    secondMatrixString += secondMatrix[i, j].ToString() + " ";
                }
                firstMatrixString += "\n";
                secondMatrixString += "\n";
            }

            Console.WriteLine($"Первая матрица: \n{ firstMatrixString }");
            Console.WriteLine($"Вторая матрица: \n{ secondMatrixString }");
            
            Console.WriteLine("Третья матрица: ");
            
            // Погугли как выполняется умножение матриц, там строка умножается на столбец, только если количество совпадает.
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    thirdMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
                    Console.Write(thirdMatrix[i,j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
