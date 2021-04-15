using System;

namespace ComputerScineceFunctionSortArrayASC
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            int[] array = new int[5];
            
            Console.Write("Начальный массив: ");
            SetAnArrayOfNumbers(array);
            
            Console.WriteLine();
            
            Console.Write("Отсортированный массив: ");
            GetSortArrayASC(array);
        }

        private static void SetAnArrayOfNumbers(int[] array)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 999);
                
                Console.Write($" {array[i]}");
            }
        }

        private static void GetSortArrayASC(int[] array)
        {
            int[] sortArray = new int[array.Length];
            
            int sumDigits = 0;
            int remainder;
            
            int i = 0;
            

            foreach (int itemInArray in array)
            {
                remainder = itemInArray;
                
                while (remainder > 0)
                {
                    sumDigits += remainder % 10;

                    remainder /= 10;
                }

                sortArray[i] = sumDigits;

                sumDigits = 0;
                
                i++;
            }
            
            for (int j = 0; j < sortArray.Length; j++)
            {
                i = 0;
                
                for (int k = 1; k < sortArray.Length; k++)
                {
                    if (sortArray[k] < sortArray[i])
                    {
                        sumDigits = sortArray[k];
                        sortArray[k] = sortArray[i];
                        sortArray[i] = sumDigits; 
                        
                        remainder = array[k];
                        array[k] = array[i];
                        array[i] = remainder;
                    }

                    i++;
                }
            }
            
            PrintArray(array);
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