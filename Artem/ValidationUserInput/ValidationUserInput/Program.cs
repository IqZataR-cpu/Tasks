using System;

namespace ValidationUserInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input;

            Console.WriteLine("Введите любое число: ");
            input = int.Parse(Console.ReadLine());

            if (input == 10)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }
    }
}
