using System;

namespace ComputerScineceFunctionSortArrayASC
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            int[] array = new int[5];
            
            Console.Write("Начальный массив: ");
            GetAnArrayOfNumbers(array);
            
            Console.WriteLine();
            
            Console.Write("Отсортированный массив: ");
            GetSortArrayASC(array);
        }

        private static void GetAnArrayOfNumbers(int[] array)
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
            int[] AscArray = new int[array.Length];
            
            int firstNumber = 0;
            int secondNumber;
            
            int i = 0;
            

            foreach (int result in array)
            {
                secondNumber = result;
                
                while (secondNumber > 0)
                {
                    firstNumber += secondNumber % 10;

                    secondNumber /= 10;
                }

                AscArray[i] = firstNumber;

                firstNumber = 0;
                
                i++;
            }
            
            for (int j = 0; j < AscArray.Length; j++)
            {
                i = 0;
                
                for (int k = 1; k < AscArray.Length; k++)
                {
                    if (AscArray[k] < AscArray[i])
                    {
                        firstNumber = AscArray[k];
                        AscArray[k] = AscArray[i];
                        AscArray[i] = firstNumber; 
                        
                        secondNumber = array[k];
                        array[k] = array[i];
                        array[i] = secondNumber;
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