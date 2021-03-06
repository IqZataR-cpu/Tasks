using System;

namespace ConsoleApp8
{
    public class Functions
    {
        public static int[] FillArray(int[] array)
        {
           
            Random rnd = new Random();
            // Вносим данные в массив.
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10,10);
                Console.Write($" {array[i]}");
            }

            Console.WriteLine();
            return array;
        }

        public static int FindMinimum(int[] array)
        {
            int min = array[0];
            // Проверяем четность\нечетность. Выдялем мин элемент.
            for (int i = 1; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
            }
            
            return min;
        }
    }
}