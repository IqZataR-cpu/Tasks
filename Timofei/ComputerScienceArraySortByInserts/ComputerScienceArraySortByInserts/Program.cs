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
            int[] arrayNumber = new int[] {40, 30, 10, 70, 50, 20, 60};
            
            InsertNumberByArray(arrayNumber);

            // Круто, что ты сделал две сортировки сразу, но
            // Когда вызывается сортировка вставками, ей если
            // Что передается уже отсортированный массив, так что
            // Суть сортировки пропадает, либо добавь ещё один массив
            // Либо по отдельности реализуй задачи
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

            // Для вывода сделай функцию или метод, чтобы не было
            // Дубляжа кода и перполнение ответственности у методов
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write($"{arrayNumber[i]} ");
            }
        }

        // Метод сортировки пузырька реализован неверно,
        // Суть метода заключается в проверке двух соседних
        // Элементов массива, а не так как у тебя реализовано
        static void SortByBooble(int[] arrayNumber)
        {
            Console.Write("Сортировка методом пузырька: ");

            // Название переменной не отражает суть испрользование переменной
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

            // Для вывода сделай функцию или метод, чтобы не было
            // Дубляжа кода и перполнение ответственности у методов
            for (int i = 0; i < arrayNumber.Length; i++)
            {
                Console.Write($"{arrayNumber[i]} ");
            }
        }
    }
}