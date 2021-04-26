using System;

namespace NumberCountEvenAndOdd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input;
            int evenCount;
            int oddCount;

            Console.WriteLine("Введите число");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine($"В числе {input}, четных чисел {evenCount = CountEven(input)}, " +
                $"нечетных чисел {oddCount = CountOdd(input)}"
                );
        }

        private static int CountEven(int number)
        {
            int count = 0;
            
            while (number > 0)
            {
                count = CountEven(number / 10);

                if (number % 2 == 0)
                {
                    count++;
                }

                return count;
            }

            return count;
        }


        private static int CountOdd(int number)
        {
            int count = 0;

            while (number > 0)
            {
                count = CountOdd(number / 10);

                if (number % 2 == 1)
                {
                    count++;
                }

                return count;
            }

            return count;
        }
    }
}
