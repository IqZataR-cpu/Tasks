using System;

namespace ComputerScienceFunctionPow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Не использовать стандартной математической функции вычисления степени.
            
            Console.Write ("Введите число ");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.Write ("Введите степень ");
            int power = int.Parse(Console.ReadLine());
            
            PowNumber(inputNumber,power);
        }
        
        static void PowNumber(int inputNumber,int power)
        {
            int powNumber = inputNumber;

            for (int i = 0; i < power - 1; i++)
            {
                powNumber *= inputNumber;
            }

            Console.WriteLine($"Ответ: {powNumber}");
        }
    }
}