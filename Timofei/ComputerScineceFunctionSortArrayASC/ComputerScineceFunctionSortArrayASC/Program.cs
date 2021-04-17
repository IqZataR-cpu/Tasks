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

        // fillArray better name
        private static void SetAnArrayOfNumbers(int[] array)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(10, 999);
                
                Console.Write($" {array[i]}");
            }
        }
        
        // You can write only "sort", dont need to translate all of this actions
        private static void GetSortArrayASC(int[] array)
        {
            int firstNumber = 0;
            // really need this variable? We dont need to store summ of digits
            int nextNumber = 0;

            // really need this variable? look bubble sort algorithm
            int i;
            
            for (int j = 0; j < array.Length; j++)
            {
                // really need this variable?
                i = 0;
                
                for (int k = 1; k < array.Length; k++)
                {
                    firstNumber = GetSumDigits(array[i]);
                    // really need this variable?
                    nextNumber = GetSumDigits(array[k]);

                    if (nextNumber < firstNumber)
                    {
                        firstNumber = array[k];
                        array[k] = array[i];
                        array[i] = firstNumber;
                    }
                    
                    // really need this variable?
                    i++;
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
