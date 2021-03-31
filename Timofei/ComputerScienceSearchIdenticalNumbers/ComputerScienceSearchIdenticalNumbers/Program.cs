using System;
using System.Collections.Generic;

namespace ComputerScienceSearchIdenticalNumbers
{ 
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите первое число: "); 
            int inputFirstNumbers = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int inputSecondNubers = int.Parse(Console.ReadLine());
            
            int[] firstArray = new int[inputFirstNumbers.ToString().Length];
            int[] secondArray = new int[inputSecondNubers.ToString().Length];
            List<int> arrayIdenticalNubers = new List<int>();
            
            firstArray = InsertNumberToArray(inputFirstNumbers, firstArray);
            secondArray = InsertNumberToArray(inputSecondNubers, secondArray);
            
            arrayIdenticalNubers = GetSearchIdenticalNumbers(firstArray, secondArray, arrayIdenticalNubers);

            PrintIdenticalNumbers(arrayIdenticalNubers);
        }

        public static void PrintIdenticalNumbers(List<int> arrayIdenticalnubers)
        {
            Console.Write("Цифры, входящие в запись как первого так и второго числа: ");
            
            foreach (var nuber in arrayIdenticalnubers)
            {
                Console.Write($"{nuber} ");
            }
        }
        
        public static List<int> GetSearchIdenticalNumbers(int[] firstArray, int[] secondArray, List<int> arrayIdenticalNubers)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                    {
                        if (arrayIdenticalNubers.Contains(firstArray[i]))
                        {
                            
                        }
                        else
                        {
                            arrayIdenticalNubers.Add(firstArray[i]);
                        }
                    }
                }
            }

            return arrayIdenticalNubers;
        }
        
        public static int[] InsertNumberToArray(int inputNubers, int[] array)
        {
            int count = inputNubers.ToString().Length;
            
            for (int i = count - 1; i > -1; i--)
            {
                array[i] = inputNubers % 10;
                inputNubers /= 10;
            }
            
            return array;
        }
    }
}