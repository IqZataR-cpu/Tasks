﻿using System;
using System.Collections.Generic;

namespace DecNumberInHex
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int userInput;
            string hexNumber = null;

            Console.WriteLine("Введите число:");
            userInput = int.Parse(Console.ReadLine());

            Console.Write($"\nЧисло {userInput} в шестнадцатиричной системе счисления выглядит ");
            if (userInput < 0)
            {
                hexNumber = "-";
                userInput = -userInput;
            }
            
            Console.Write($"так - {hexNumber += Translator(userInput)}");
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
                if (i == number)
                {
                    return hexNumber = hexNumbers[i].ToString();                    
                }
            }

            return hexNumber;
        }
    }
}
