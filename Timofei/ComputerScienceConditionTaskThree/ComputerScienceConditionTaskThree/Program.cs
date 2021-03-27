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

            // Вынести в отдельные функции как сравнение, так и функцию просчета уравнения.
            double result = EquationSolution(inputA);
            
            CompareSolution(inputB, result);
        }

        static void CompareSolution(int inputB, double result)
        {
            Console.WriteLine(inputB == result);
        }
        
        static double EquationSolution(int x)
        {
            return (5 * Math.Pow(x, 2) - 7 * x + 2);
        }
    }
}
