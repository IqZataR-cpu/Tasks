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

            double average = AverageEven(numbers);
            Console.WriteLine("Ср. арифмитическое всех четных чисел стоящих " +
                $"на нечетных местах равно {average}");
        }

        static int[] CreateArray(int countElements)
        {
            Random random = new Random();
            int[] numbers = new int[countElements];

            for(int i = 0; i <= countElements - 1; i++)
            {
                numbers[i] = random.Next(20);
            }

            return numbers;
        }

        static double AverageEven(int[] numbers)
        {
            double average = 0;
            int countNumbers = new int();

            for (int i = 0; i<= numbers.Length - 1; i += 2)
            {
                if (isEvenNumber(numbers[i]))
                {
                    average += numbers[i];
                    countNumbers++;
                }
            }

            return average / countNumbers;
        }

        static bool isEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }

        static void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
