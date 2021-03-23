using System;

namespace Cycle_Easy_1
{
    class Program
    {
        // Комментарии подобного вида как у тебя это излишне!!!
        // Удали их просто или буду писать FUCK MOY MOZG!!! =) (=
        // UPD. Решил сам их удалить, но запомни на будущее!
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            // не выделил пробелами
            int countRemain=0;
            // не выделил пробелами
            int countNoRemain=0;
            
            // не выделил пробелами
            while (n>0)
            {
                temp = n % 10;
                n /= 10; 
                // не выделил пробелами
                if (temp%2==0)
                {
                    countRemain++;
                }
                else
                {
                    countNoRemain++;
                }
            }

            Console.WriteLine($"Количество счетных чисел: {countRemain}");
            Console.WriteLine($"Количество счетных чисел: {countNoRemain}");
        }
    }
}
