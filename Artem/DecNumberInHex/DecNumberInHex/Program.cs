using System;
using System.Collections.Generic;

namespace DecNumberInHex
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string hexNumber = null;

            Console.WriteLine("Введите число:");
            userInput = int.Parse(Console.ReadLine());

            if (userInput < 0)
            {
                hexNumber = "-";
                userInput = -userInput;
                Console.WriteLine($"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                    $"так - {hexNumber += Translator(userInput)}");
                return;
            }

            Console.WriteLine($"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                    $"так - {hexNumber += Translator(userInput)}");
        }

        static string Translator(int number)
        {
            string hexNumber = null;
            int remains = number % 16;

            if (number >= 16)
            {
                hexNumber += Translator(number / 16);
                return hexNumber += HexTranslator(remains);
            }           
           else
            {
                hexNumber += HexTranslator(number);
            }

            return hexNumber;
        }

        static string HexTranslator(int number)
        {
            Dictionary<int, char> hexNumbers = new Dictionary<int, char>
            {
                {0, '0'},
                {1, '1'},
                {2, '2'},
                {3, '3'},
                {4, '4'},
                {5, '5'},
                {6, '6'},
                {7, '7'},
                {8, '8'},
                {9, '9'},
                {10, 'A'},
                {11, 'B'},
                {12, 'C'},
                {13, 'D'},
                {14, 'E'},
                {15, 'F'}
            };
            string hexNumber = null;

            foreach (var numbers in hexNumbers)
            {
                if (numbers.Key == number)
                {
                    hexNumber = numbers.Value.ToString();
                }
            }

            return hexNumber;
        }
    }
}
