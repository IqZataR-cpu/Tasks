using System;

namespace ComputerScienceMartixReverseString
{
    class Program
    {
        const int sizeLine = 4;
        const int sizeColumn = 4;
        // Разделяем свойства и методы интером.
        static void Main(string[] args)
        {
            int[,] matrix = new int[sizeLine, sizeColumn];
            
            // Работа с матрицей является одним логическим блоком,
            // поэтому я думаю можно интер между вызовами методов не ставить. 
            InsertNumberToMatrix(matrix);
                
            ReverseMatrix(matrix);
        }
        
        static void PrintMatrix(int[,] matrix)
        {
            // табуляция
       for (int i = 0; i < sizeLine; i++)
            {
                for (int j = 0; j < sizeColumn; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                
                Console.WriteLine();
            }
            
            Console.WriteLine();
        }
        
        // Более лаконичное название FillMatrix
        static void InsertNumberToMatrix(int[,] matrix)
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
            
            Console.WriteLine();
        }

        static void ReverseMatrix(int[,] matrix)
        {
            int[] fisrtLine = new int[sizeLine];
            int[] secondLine = new int[sizeLine];
                
            // не забываем пробелы между аргументами функции
            matrix = ReverseFirstString(fisrtLine,matrix);
            matrix = ReverseSecondString(secondLine, matrix);
              
            PrintMatrix(matrix);
            // лишние enter
                
        }

        static int[,] ReverseFirstString(int[] firstLine, int[,] matrix)
        {
            // Ты действительно уверен что эти переменные здесь нужны?
            int indexJ = 3;
            int indexK = 0;
                
            for (int i = 3; i > -1; i--)
            { 
                firstLine[i] = matrix[i, indexJ];
                indexJ--;
            }
                
            indexJ = 3;
            
            for (int i = 0; i < sizeLine; i++)
            {
                matrix[i, indexK] = firstLine[indexJ];
                indexJ--;
                indexK++;
            }
                
            return matrix;
        }
    
        // в целом поработав с индексами, можно действительно сделать одним циклом, по желанию
        static int[,] ReverseSecondString(int[] secondLine, int[,] matrix)
        { 
            // Действительно нужна?
            int indexK = 3;
                
            for (int i = 0; i < sizeLine; i++)
            { 
                secondLine[indexK] = matrix[i, indexK]; 
                indexK--;
            }
                
            indexK = 3;
                
            for (int i = 0; i < sizeLine; i++)
            {
                matrix[i, indexK] = secondLine[i];
                indexK--;
            }

            return matrix;
        }
    }
}
