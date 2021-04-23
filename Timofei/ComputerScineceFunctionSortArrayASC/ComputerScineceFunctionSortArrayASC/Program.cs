using System;

namespace ComputerScineceFunctionSortArrayASC
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            int[] array = new int[5];
            
            Console.Write("Начальный массив: ");
            FillArray(array);
            
            Console.WriteLine();
            
            Console.Write("Отсортированный массив: ");
            Sort(array);
        }
        
        private static void FillArray(int[] array)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 999);
                
                Console.Write($" {array[i]}");
            }
        }
        
        private static void Sort(int[] array)
        {
            int firstNumber = 0;
      
            for (int j = 0; j < array.Length; j++)
            {
                for (int k = 1; k < array.Length; k++)
                {
                    firstNumber = GetSumDigits(array[k - 1]);
                    
                    if (GetSumDigits(array[k]) < firstNumber)
                    {
                        firstNumber = array[k];
                        array[k] = array[k - 1];
                        array[k - 1] = firstNumber;
                    }
                }
            }
        
            PrintArray(array);
        }
        
        private static int GetSumDigits(int number)
        {
            int sumDigits = 0;
            
            while (number > 0)
            {
                sumDigits += number % 10;

                number /= 10;
            }

            return sumDigits;
        }
        
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
