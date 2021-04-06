using System;

namespace AverageEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива: ");
            int countElements = int.Parse(Console.ReadLine());

            int[] numbers = CreateArray(countElements);
            Print(numbers);

            Console.WriteLine("Ср. арифмитическое всех четных чисел стоящих " +
                $"на нечетных местах равно { AverageEven(numbers)}");
        }

        private static int[] CreateArray(int countElements)
        {
            Random random = new Random();
            int[] numbers = new int[countElements];

            for (int i = 0; i <= countElements - 1; i++)
            {
                numbers[i] = random.Next(20);
            }

            return numbers;
        }

        private static double AverageEven(int[] numbers)
        {
            double average = 0;
            int numbersCount = 0;

            for (int i = 0; i <= numbers.Length - 1; i += 2)
            {
                if (isNumberEven(numbers[i]))
                {
                    average += numbers[i];
                    numbersCount++;
                }
            }

            return average / numbersCount;
        }

        private static bool isNumberEven(int number)
        {
            return number % 2 == 0;
        }

        private static void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
