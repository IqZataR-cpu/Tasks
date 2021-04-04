using System;

namespace ComputerScienceArrayDistance
{
    class Program
    {
        static void Main(string[] args)
        {
          //При заданных координатах A1, A2, An одной точки и координатах B1, B2, Bn другой точки n-мерного пространства.
          //Найти расстояние между ними по формуле sqrt(sqr(A1-B1) + sqr(An-Bn)).
            
            double[] arrayA = new double[4];
            double[] arrayB = new double[4];
            double distance = 0;
            
            arrayA = InsertToArray(arrayA);
            arrayB = InsertToArray(arrayB);
            
            for (int i = 0; i < arrayA.Length; i++)
            {
                distance += Math.Pow(arrayA[i] - arrayB[i], 2);
            }
            
            Console.WriteLine($"Расстояние от (А до В) = {Math.Round(Math.Sqrt(distance))}");
        }
       
        private static double[] InsertToArray(double[] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 10);
            }

            return array;
        }
    }
}