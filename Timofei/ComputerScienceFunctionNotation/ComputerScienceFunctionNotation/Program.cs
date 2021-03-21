using System;

namespace ComputerScienceFunctionNotation
{
    class Program
    {
        public const int HEXADECIMAL_NOTATION = 16;
           
        static void Main(string[] args)
        {
            Console.Write("Введите число в десятерично системе счисления: ");
            int inputNumber = int.Parse(Console.ReadLine());
            
            ConvertDecimalToHexadecimalNotation(inputNumber);
        }

        static void ConvertDecimalToHexadecimalNotation(int inputNumber)
        {
            string numberInHexadecimalNotation = "";
            while (inputNumber > 0)
            {
                numberInHexadecimalNotation += Convert.ToString(inputNumber % HEXADECIMAL_NOTATION);
                inputNumber /= HEXADECIMAL_NOTATION;
            }

            for (int i = numberInHexadecimalNotation.Length; i != 0; i--)
            {
                Console.WriteLine($"Число в шестнадцатеричной системе: {Convert.ToChar(numberInHexadecimalNotation[i])}");
            }
           
        }
    }
}