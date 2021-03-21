using System;

namespace ComputerScienceArraySortByInserts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumber = new int[] {40, 30, 10, 70, 50, 20, 60};
            
            InsertNumberByArray(arrayNumber);
            
            SortByBooble(arrayNumber);
            Console.WriteLine();
            SortByInsert(arrayNumber);
        }

        static int[] InsertNumberByArray(int[] array)
        {
            Random randomNumber = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomNumber.Next(100);
            }

            return array;
        }

        static void SortByInsert(int[] arrayNumber)
        {
            Console.Write("Сортировка методом вставки: ");
            
            for (int i = 1; i < arrayNumber.Length; i++)
            {
                int step = arrayNumber[i];
                int j = i;
                while (j > 0 && step < arrayNumber[j - 1])
                {
                    arrayNumber[j] = arrayNumber[j - 1];
                    j--;
                }
                arrayNumber[j] = step;
            }

            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write($"{arrayNumber[i]} ");
            }
        }

        static void SortByBooble(int[] arrayNumber)
        {
            Console.Write("Сортировка методом пузырька: ");
            
            int step = arrayNumber[0];
            
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                for (int j = i + 1; j < arrayNumber.Length; j++)
                {
                    if (arrayNumber[j] < arrayNumber[i])
                    {
                        step = arrayNumber[j];
                        arrayNumber[j] = arrayNumber[i];
                        arrayNumber[i] = step;
                    }
                }
            }
            
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write($"{arrayNumber[i]} ");
            }
        }
    }
}