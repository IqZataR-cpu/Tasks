using System;

namespace ComputerScienceCyclesOutputNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выведите числа от 1 до 100 без использования чисел в коде.
            
            string minNumber = "|";
            string maxNumer = "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "||||||||||" +
                              "|||||||||||";

            for (int i = minNumber.Length; i < maxNumer.Length; i++)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}