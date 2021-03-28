using System;

namespace ComputerScienceMartixReverseString
{
    class Program
    {
        const int sizeLine = 4;
        const int sizeColumn = 4;
        static void Main(string[] args)
        {
            // int[,] matrix = new int[sizeLine, sizeColumn];

            int[,] matrix = new int[sizeLine, sizeColumn];
            
            InsertNumberToMatrix(matrix);
                
            ReverseMatrix(matrix);
        }
        
        static void PrintMatrix(int[,] matrix)
        {
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
                
            matrix = ReverseFirstString(fisrtLine,matrix);
            matrix = ReverseSecondString(secondLine, matrix);
              
            PrintMatrix(matrix);
                
        }

        static int[,] ReverseFirstString(int[] firstLine, int[,] matrix)
        {
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

        static int[,] ReverseSecondString(int[] secondLine, int[,] matrix)
        { 
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