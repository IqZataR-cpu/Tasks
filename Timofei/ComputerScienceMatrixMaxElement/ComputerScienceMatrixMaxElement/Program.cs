using System;

namespace ComputerScienceMatrixMaxElement
{
    class Program
    {
        const int sizeLine = 4;
        const int sizeColumn = 4;

        static void Main(string[] args)
        {
            int[,] matrix = new int[sizeLine, sizeColumn];

            PrintMatrix(matrix);
            SearchMaxElement(matrix);
        }

        // Помним про разделение ответственностей, здесь их 2,
        // то есть название функции не соответствует действительности
        static void PrintMatrix(int[,] matrix)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < sizeLine; i++)
            {
                for (int j = 0; j < sizeColumn; j++)
                {
                    matrix[i, j] = rnd.Next(99);
                    
                    Console.Write($"{matrix[i, j]} ");
                }
                
                Console.WriteLine();
            }
        }

        // Тут я бы тоже указал, что ищется именно максимальный диагональный элемент.
        static void SearchMaxElement(int[,] matrix)
        {
            int maxElement = matrix[0, 0];
            int indexI = 0, indexJ = 0;
            
            // Такие циклы конечно круто, но старайся ими не пользоваться,
            // просто знай, что такое существует, но это не любят обычно
            for (int i = 1, j = 1; i < sizeColumn; i++, j = i)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    indexI = i;
                    indexJ = j;
                }
            }
            
            // Такие циклы конечно круто, но старайся ими не пользоваться,
            // просто знай, что такое существует, но это не любят обычно
            for (int i = sizeLine - 1, j = 0; i > -1; i--, j++)
            {
                if (matrix[i, j] > maxElement)
                {
                    maxElement = matrix[i, j];
                    indexI = i;
                    indexJ = j;
                }
            }

            // то есть пробелы между знаками в коде мы ставим, а тут нет?
            Console.WriteLine($"Индекс максимального элемента двух диагоналей:[{indexI},{indexJ}] = {maxElement}");
        }
    }
}
