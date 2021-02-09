using System;

namespace RemoveDigitFromNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            Number number = new Number(int.Parse(Console.ReadLine()));
            
            Console.Write("Введите цифру, которую хотите убрать из числа:");
            number.RemoveDigital(int.Parse(Console.ReadLine()));

            number.Print();
        }
    }
}
