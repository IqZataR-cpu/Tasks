using System;

namespace Cycle_Easy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int inputValue = int.Parse(Console.ReadLine());
            int countRemain = 0;
            int countNoRemain = 0;
            
            while (inputValue > 0)
            {
                inputValue /= 10; 
                if ((inputValue % 10) % 2 == 0)
                {
                    countRemain++;
                }
                else
                {
                    countNoRemain++;
                }
            }

            Console.WriteLine($"Количество четных чисел: {countRemain}");
            Console.WriteLine($"Количество нечетных чисел: {countNoRemain}");
        }
    }
}
