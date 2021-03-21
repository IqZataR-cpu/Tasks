using System;

namespace Matrix_Medium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.Write("Введите количество столбцов в матрицах: "); //задаем размер матриц
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк в матрицах: ");
            int j = int.Parse(Console.ReadLine());
            int column = i;
            int row = j;
            int[,] firstMatrix = new int[i,j]; //создаем двумерные массивы
            int[,] secondMatrix = new int[i,j];
            int[,] thirdMatrix = new int[i,j];
            
            Console.WriteLine("Первый массив: ");
            
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    firstMatrix[i, j] = rnd.Next(0, 10); //заполняем случайными значениями
                    Console.Write(firstMatrix[i,j]+ " "); //выводим на экран
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Второй массив: ");
            
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    secondMatrix[i, j] = rnd.Next(0, 10); //заполняем случайными значениями
                    Console.Write(secondMatrix[i,j]+ " "); //выводим на экран
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Третий массив: ");
            
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    thirdMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j]; //переумножаем элементы 2-х матриц
                    Console.Write(thirdMatrix[i,j]+ " "); //выводим на экран результат
                }
                Console.WriteLine();
            }
        }
    }
}