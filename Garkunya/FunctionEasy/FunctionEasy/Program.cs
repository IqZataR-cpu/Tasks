using System;

namespace FunctionEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");

            int yourNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите степень: ");

            int degreeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Получившиеся число: {Degree(yourNumber, degreeNumber)}");
        }

        static int Degree(int returnNumber, int degree)
        {
            int number = returnNumber;
            
            for (int i = 1; i < degree; i++)
            {
                returnNumber *= number;
            }
            
            return returnNumber;
        }
    }
}