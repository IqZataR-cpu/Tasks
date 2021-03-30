using System;

namespace N_rankedSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность пространства");
            int rankSpace = int.Parse(Console.ReadLine());

            int[] dotA = CreateDot(rankSpace);
            PrintArray(dotA);
            int[] dotB = CreateDot(rankSpace);
            PrintArray(dotB);

            double distance = Distance(dotA, dotB);
            Console.WriteLine($"Расстояние в {rankSpace}-пространстве равна {distance}");

        }

        public static int [] CreateDot(int countCoordinates)
        {
            Random randomNumber = new Random();
            int[] dot = new int[countCoordinates];

            for (int i = 0; i <= dot.Length - 1; i++)
            {
                dot[i] = randomNumber.Next(10);
            }

            return dot;
        }

        public static double Distance(int[] dotA, int[] dotB)
        {
            double distance = 0;

            for (int i = 0; i <= dotA.Length - 1; i++)
            {
                distance += Math.Pow(dotA[i] - dotB[i], 2);
            }

            return Math.Sqrt(distance);
        }

        public static void PrintArray(int[] dot)
        {            
            foreach (int number in dot)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
