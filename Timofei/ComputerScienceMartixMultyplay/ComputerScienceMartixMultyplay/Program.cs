using System;

namespace ComputerScienceMatrixMultiply
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[,] matrixA = new int[,]
            {
                {1, 4, 3},
                {2, 1, 5},
                {3, 2, 1}
            };
            
            int[,] matrixB = new int[,]
            {
                {5, 2, 1},
                {4, 3, 2},
                {2, 1, 5}
            };

            int[,] matrixC = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int sum = 0;
                    
                    for (int k = 0; k < 3; k++)
                    {
                        sum += matrixA[i, k] * matrixB[k, j];
                        
                        matrixC[i, j] = sum;
                    }

                    Console.Write($"{matrixC[i,j]} ");   
                }
                
                Console.WriteLine();
            }
        }
    }
}