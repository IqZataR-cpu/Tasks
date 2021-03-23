using System;

namespace Cycle_Easy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int inputValue = int.Parse(Console.ReadLine());
            int temp = 0;
            int countRemain = 0;
            int countNoRemain = 0;
            
            while (inputValue > 0)
            {
                temp = inputValue % 10;
                inputValue /= 10; 
                if (temp %  2== 0)
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
