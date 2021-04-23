using System;

namespace QuickSortBySumDigits
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers;
            int userInput;

            Console.WriteLine("Введите количество чисел: ");
            userInput = int.Parse(Console.ReadLine());

            numbers = CreateArray(userInput);

            PrintArray(numbers);
            QuickSort(numbers, 0, numbers.Length - 1);
            PrintArray(numbers);
            PrintSumDigits(numbers);
        }

        private static int[] CreateArray(int numberCount)
        {
            Random random = new Random();
            int[] numbers = new int[numberCount];

            for (int i = 0; i <= numberCount - 1; i++)
            {
                numbers[i] = random.Next(200);
            }

            return numbers;
        }

        private static void QuickSort(int[] numbers, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivot = Sorting(numbers, left, right);
            QuickSort(numbers, left, pivot - 1);
            QuickSort(numbers, pivot + 1, right);
        }

        private static int Sorting(int[] numbers, int left, int right)
        {
            int pointer = left;
            int rightNumber = SumDigits(numbers[right]);
            int intermediateSum = 0;

            for (int i = left; i <= right; i++)
            {
                intermediateSum = SumDigits(numbers[i]);

                if (intermediateSum < rightNumber)
                {
                    Swap(numbers, pointer, i);
                    pointer++;
                }
            }

            Swap(numbers, pointer, right);
            return pointer;
        }

        private static void Swap(int[] numbers, int firstNumber, int secondNumber)
        {
            int intermediate = numbers[firstNumber];
            numbers[firstNumber] = numbers[secondNumber];
            numbers[secondNumber] = intermediate;
        }

        private static int SumDigits(int number)
        {
            int summary = 0;

            while (number > 0)
            {
                summary += number % 10;
                number /= 10;
            }

            return summary;
        }

        private static void PrintArray(int[] numbers)
        {
            Console.WriteLine("Массив: ");

            foreach (var numberItem in numbers)
            {
                Console.Write($"{numberItem} ");
            }

            Console.WriteLine();
        }

        private static void PrintSumDigits(int[] numbers)
        {
            Console.WriteLine("Сумма цифр по элементам: ");

            foreach (var numberItem in numbers)
            {
                Console.Write($"{SumDigits(numberItem)} ");
            }

            Console.WriteLine();
        }
    }
}
