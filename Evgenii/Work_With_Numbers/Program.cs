using System;
using System.Collections.Generic;

namespace Work_With_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberByUnits = new List<int> { };

            Console.WriteLine("Введите число");
            int inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber > 0)
            {
                numberByUnits.Add(inputNumber % 10);
                inputNumber = inputNumber / 10;
            }

            int countEven = 0;
            int countOdd = 0;

            for (int i = 0; i < numberByUnits.Count; i++)
            {
                if (numberByUnits[i] % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;

                }
            }

            Console.WriteLine($"Четных цифр в числе {countEven}, нечетных {countOdd}");
        }
    }
}
