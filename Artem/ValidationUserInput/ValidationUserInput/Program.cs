using System;

namespace ValidationUserInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int userInput;

            Console.WriteLine("Введите любое число: ");
            userInput = int.Parse(Console.ReadLine());

            if (isNumberOfTen(userInput))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }

        private static bool isNumberOfTen(int number)
        {
            return number == 10;
        }
    }
}
