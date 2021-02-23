using System;

namespace HardFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[16] { 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536 };
            int inputNumber;
            int numberOfElementArray;

            Console.WriteLine("Введите число");
            inputNumber = int.Parse(Console.ReadLine());

            numberOfElementArray = BinarySearching(numbers, inputNumber);

            if (numberOfElementArray == 0)
            {
                Console.WriteLine($"Число {inputNumber} не существует в массиве");
                return;
            }

            Console.WriteLine($"Число {inputNumber} существует в массиве и оно находится на {numberOfElementArray} месте");
        }

        static int BinarySearching(int[] numbers, int number)
        {
            const int zero = 0;
            int lengthArray = numbers.Length - 1;
            int middleArray = lengthArray / 2;


            bool isNumberEqualsNumberOfArray = number == numbers[middleArray];
            if (isNumberEqualsNumberOfArray)
            {
                return middleArray;
            }

            bool isNumberMoreThanMiddle = number > numbers[middleArray];
            if (isNumberMoreThanMiddle)
            {
                for (int i = middleArray + 1; i <= numbers.Length; i++)
                {
                    isNumberEqualsNumberOfArray = number == numbers[i];

                    if (isNumberEqualsNumberOfArray)
                    {
                        return i + 1;
                    }
                }
            }
            else
            {
                for (int i = middleArray - 1; i >= 0; i--)
                {
                    isNumberEqualsNumberOfArray = number == numbers[i];

                    if (isNumberEqualsNumberOfArray)
                    {
                        return i + 1;
                    }
                }
            }

            return zero;
        }
    }
}