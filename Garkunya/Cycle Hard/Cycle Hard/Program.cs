using System;

namespace Cycle_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourNumber = 0;
            int countOperation = 0;
            bool endOperation;
            
            Console.Write("Введите число: ");
            yourNumber = int.Parse(Console.ReadLine());
            
            while (yourNumber != 1)
            {
                endOperation = yourNumber % 2 == 0;
                countOperation++;

                if (endOperation)
                {
                    yourNumber = yourNumber / 2;
                    continue;
                }

                yourNumber = (yourNumber * 3 + 1) / 2;
            }
            Console.WriteLine($"Количество операций: {countOperation}");
        }
    } 
}

