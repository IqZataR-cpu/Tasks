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
            
            double result = EquationSolution(inputA);
            bool resultCompare = CompareSolution(inputB, result);
            
            Console.WriteLine(resultCompare);
        }

        static bool CompareSolution(int inputB, double result)
        {
           return inputB == result;
        }
        
        static double EquationSolution(int x)
        {
            return 5 * Math.Pow(x, 2) - 7 * x + 2;
        }
    }
}
