using System;
using System.Collections.Generic;

namespace DecNumberInHex
{
    // Не забываем везде указывать область видимости, 
    // даже если работаем в пределах одного класса или метода
    // Здесь не указал
    class Program
    {
        // Здесь не указал
        static void Main(string[] args)
        {
            int userInput;
            string hexNumber = null;

            Console.WriteLine("Введите число:");
            userInput = int.Parse(Console.ReadLine());

            if (userInput < 0)
            {
                hexNumber = "-";\
                // По сути это дубляж кода, так что исправь
                Console.WriteLine(
                    $"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                    $"так - {hexNumber += Translator(-userInput)}"
                );
                return;
            }

            Console.WriteLine(
                $"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                $"так - {hexNumber += Translator(userInput)}"
            );
        }

        private static string Translator(int number)
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

        private static string HexTranslator(int number)
        {
            char[] hexNumbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            string hexNumber = null;
                  
            for (int i = 0; i <= hexNumbers.Length - 1; i++)
            {
                // Находим нужный намбер (1) и все равно продолжаем проверять до конца цикла, но зачем?
                if (i == number)
                {
                    hexNumber = hexNumbers[i].ToString();
                }
            }

            return hexNumber;
        }
    }
}
