using System;

namespace ComputerScienceConditionTaskThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату a = ");
            int inputA = int.Parse(Console.ReadLine());
            Console.Write("Введите координату b = ");
            int inputB = int.Parse(Console.ReadLine());

            bool result = inputB == 5 * Math.Pow(inputA, 2) - 7 * inputA + 2;
            
            Console.WriteLine(result);
        }
    }
}