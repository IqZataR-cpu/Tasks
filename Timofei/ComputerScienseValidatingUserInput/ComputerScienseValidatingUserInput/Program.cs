using System;

namespace ComputerScienseValidatingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Если переменная a равна 10, то выведите 'Верно', иначе выведите 'Не верно'.
            
            int  dataInput = int.Parse(Console.ReadLine());

            if (dataInput == 10)
            {
                Console.WriteLine("Верно.");
            }
            else
            {
                Console.WriteLine("Не верно.");
            }
        }
    }
}