using System;

namespace ComputerScienceArraySortByInserts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Для чего здесь ты делаешь массив с данными, если
            // Если ты вызываешь метод, который заполнит массив заново
            // Другими значениями
            int[] arrayNumberOne = new int[10];
            
            int[] arrayNumberTwo = new int[10];
            
            InsertNumberByArray(arrayNumberOne);
            InsertNumberByArray(arrayNumberTwo);
            
            // Круто, что ты сделал две сортировки сразу, но
            // Когда вызывается сортировка вставками, ей если
            // Что передается уже отсортированный массив, так что
            // Суть сортировки пропадает, либо добавь ещё один массив
            // Либо по отдельности реализуй задачи
            SortByBooble(arrayNumberOne);
            Console.WriteLine();
            SortByInsert(arrayNumberTwo);
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
            PrintArray(arrayNumber);
        }

        // Метод сортировки пузырька реализован неверно,
        // Суть метода заключается в проверке двух соседних
        // Элементов массива, а не так как у тебя реализовано
        static void SortByBooble(int[] arrayNumber)
        {
            Console.Write("Сортировка методом пузырька: ");

            // Название переменной не отражает суть испрользование переменной
            int temp = arrayNumber[0];
            int k = 0;
            
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                k = 0;
                
                for (int j = 1; j < arrayNumber.Length; j++)
                {
                    if (arrayNumber[j] < arrayNumber[k])
                    {
                        temp = arrayNumber[j];
                        arrayNumber[j] = arrayNumber[k];
                        arrayNumber[k] = temp;
                    }

                    k++;
                }
            }
            
            PrintArray(arrayNumber);
        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}