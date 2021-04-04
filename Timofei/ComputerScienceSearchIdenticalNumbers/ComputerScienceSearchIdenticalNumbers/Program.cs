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
            int inputSecondNumbers = int.Parse(Console.ReadLine());
            
            int[] firstArray = new int[inputFirstNumbers.ToString().Length];
            int[] secondArray = new int[inputSecondNumbers.ToString().Length];
            List<int> arrayIdenticalNubers = new List<int>();
            
            InsertNumberToArray(inputFirstNumbers, firstArray);
            InsertNumberToArray(inputSecondNumbers, secondArray);
            
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
                        // Пустое условие, можно заменить на отрицание,
                        // !arrayIdenticalNubers.Contains(firstArray[i]) и его не будет
                        if (!arrayIdenticalNubers.Contains(firstArray[i]))
                        {
                            arrayIdenticalNubers.Add(firstArray[i]);
                        }
                    }
                }
            }

            return arrayIdenticalNubers;
        }
        
        // Зачем count? Если есть while (inputNumbers > 0)
        // Определись нужен тебе параметр в виде ссылки на массив или
        // возвращаемое значение + локальное(внутри функциии) создание массива.
        public static void InsertNumberToArray(int inputNumbers, int[] array)
        {
            int i = 0;
            while (inputNumbers > 0)
            {
                array[i] = inputNumbers % 10;
                inputNumbers /= 10;
                i++;
            }
        }
    }
}
