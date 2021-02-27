using System;

namespace HardFunction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[16] {
                2, 4, 8, 16, 32, 64, 128, 256, 512, 1024,
                2048, 4096, 8192, 16384, 32768, 65536
            };
            int inputNumber;
            int numberOfElementArray;
            int lengthArray = numbers.Length - 1;
            int rigthBorderArray = lengthArray;
            int leftBorderArray = 0;
            Console.WriteLine("Введите число");
            inputNumber = int.Parse(Console.ReadLine());

            numberOfElementArray = BinarySearching(numbers, inputNumber, leftBorderArray, rigthBorderArray);

            if (numberOfElementArray == 0)
            {
                Console.WriteLine($"Число {inputNumber} не существует в массиве");
                return;
            }

            Console.WriteLine($"Число {inputNumber} существует в массиве " +
                              $"и оно находится на {numberOfElementArray} месте");
        }

        static int BinarySearching(int[] numbers, int number, int leftBorderArray, int rightBorderArray)
        {

            const int NUMBERNOTFOUND = 0;
            int middleArray = (leftBorderArray + rightBorderArray)/2;
           
            if (middleArray == numbers.Length-2)
            {
                middleArray += 1;
            }

            bool isFind = number == numbers[middleArray];
            bool isNotFind = (leftBorderArray - middleArray == 0 || rightBorderArray - middleArray == 1);
            
            if (isFind)
            {
                return middleArray+1;
            }

            if (isNotFind)
            {
                return NUMBERNOTFOUND;
            }

            bool isNumberMoreThanMiddle = number > numbers[middleArray];

            if (isNumberMoreThanMiddle)
            {       
                
                if (!isFind)
                {
                    return BinarySearching(numbers, number, middleArray, rightBorderArray);
                }

            }
            else
            {

                if (!isFind)
                {
                    return BinarySearching(numbers, number, leftBorderArray, middleArray);
                }

            }

            return NUMBERNOTFOUND;
        }
    }
}