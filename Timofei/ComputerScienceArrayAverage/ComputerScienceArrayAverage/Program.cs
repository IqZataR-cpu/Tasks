using System;

namespace ComputerScienceArrayAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = new int[10];

            InsertNumberInArray(arrayInput);
            AverageNumbersArray(arrayInput);
        }

        static int[] InsertNumberInArray(int[] arrayInput)
        {
            Random randomNumber = new Random();

            Console.Write("Массив: ");

            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = randomNumber.Next(100);
                Console.Write($"{arrayInput[i]} ");
            }

            return arrayInput;
        }

        static void AverageNumbersArray(int[] arrayInput)
        {
            // sumAverage лучше сделать типа double or float
            // Потому что оно может быть дробным
            int sumAverage = 0;
            int count = 0;
            // Не совсем корректная фраза здесь, потому что
            // Человек видит нечетные числа, а на выводе в итоге
            // Они оказываются четными
            Console.Write($"\n Нечетные числа: ");

            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (i % 2 != 0 && arrayInput[i] % 2 == 0)
                {
                    Console.Write($"{arrayInput[i]} ");
                    sumAverage += arrayInput[i];
                    count++;
                }
            }

            Console.Write($"\n Ср. арифметическое {sumAverage / count}");
        }
    }
}