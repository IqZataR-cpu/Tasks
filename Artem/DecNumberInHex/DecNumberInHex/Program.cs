using System;
using System.Collections.Generic;

namespace DecNumberInHex
{
    // Не забываем везде указывать область видимости, 
    // даже если работаем в пределах одного класса или метода
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
                // можно было в метод отправить -userInput
                userInput = -userInput;
                // Вот так переносы строк выглядят более лаконично
                Console.WriteLine(
                    $"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                    $"так - {hexNumber += Translator(userInput)}"
                );
                return;
            }

            Console.WriteLine(
                $"Число {userInput} в шестнадцатиричной системе счисления выглядит " +
                $"так - {hexNumber += Translator(userInput)}"
            );
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
            // Поскольку ключи интовые можно было не делать Dictionary,
            // ведь обычный массив работает быстрее
            // и ключи там тоже int в таком же порядке.
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

            // I think @hexItem@ better than @numbers@ in this context
            // But hexNumbers.Contains(number) or smth like that should be better.
            // exmpl: if "contains" return hexNumbers[number] 
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
