using System;

namespace ComputerScienseValidatingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Если переменная a равна 10, то выведите 'Верно', иначе выведите 'Не верно'.
            
            int  dataInput = Int32.Parse(Console.ReadLine());
            bool validationDataInput = dataInput == 10;

            if (validationDataInput)
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