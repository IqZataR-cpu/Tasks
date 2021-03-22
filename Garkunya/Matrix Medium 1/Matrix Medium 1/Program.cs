using System;

namespace Matrix_Medium_1
{
    // Неверно выполненное задание.
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
             
            Console.Write("Введите количество столбцов в матрицах: "); //задаем размер матриц FUCK MOY MOZG!!!
            int i = int.Parse(Console.ReadLine());
            Console.Write("Введите количество строк в матрицах: ");
            int j = int.Parse(Console.ReadLine());
            int column = i;
            int row = j;
            // Не выделил знаки пробелами. я про i, j
            int[,] firstMatrix = new int[i,j]; //создаем двумерные массивы FUCK MOY MOZG!!!
            int[,] secondMatrix = new int[i,j];
            int[,] thirdMatrix = new int[i,j];
            
            Console.WriteLine("Первый массив: ");
            
            // Можно было два массива заполнить в одном цикле. КОПИПАСТА ВАНЛОВЕ!
            // Сохранить в string их консольные представления и вывести после цикла.
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    firstMatrix[i, j] = rnd.Next(0, 10); //заполняем случайными значениями FUCK MOY MOZG!!!
                    // не выделил знаки пробелами
                    Console.Write(firstMatrix[i,j]+ " "); //выводим на экран FUCK MOY MOZG!!!
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Второй массив: ");
            
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    secondMatrix[i, j] = rnd.Next(0, 10); //заполняем случайными значениями
                    // не выделил знаки пробелами
                    Console.Write(secondMatrix[i,j]+ " "); //выводим на экран
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Третий массив: ");
            
            // Погугли как выполняется умножение матриц, там строка умножается на столбец, только если количество совпадает.
            for (i = 0; i < column; i++)
            {
                for (j = 0; j < row; j++)
                {
                    thirdMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j]; //переумножаем элементы 2-х матриц FUCK MOY MOZG!!!
                    Console.Write(thirdMatrix[i,j]+ " "); //выводим на экран результат FUCK MOY MOZG!!!
                } // Лично я бы тут enter поставил, но субъективно.
                Console.WriteLine();
            }
        }
    }
}
