using System;

namespace N_rankedSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность пространства");
            int rankSpace = int.Parse(Console.ReadLine());

            Dot dotA = new Dot(rankSpace); 
            dotA.PrintArray();
            Dot dotB = new Dot(rankSpace);
            dotB.PrintArray();

            double distance = dotA.Distance(dotB);
            Console.WriteLine($"\nРасстояние в {rankSpace}-пространстве равна {distance}");
        }

        class Dot
        {
            private int[] _coordinates;

            public int[] Coordinates
            {
                get => _coordinates;
            }

            public Dot(int countCoordinates)
            {
                Random randomNumber = new Random();
                _coordinates = new int[countCoordinates];

                for (int i = 0; i <= countCoordinates - 1; i++)
                {
                    _coordinates[i] = randomNumber.Next(10);                   
                }
            }

            public double Distance(Dot dot)
            {
                double distance = 0;

                for (int i = 0; i <= _coordinates.Length - 1; i++)
                {
                    distance += Math.Pow(dot.Coordinates[i] - _coordinates[i], 2);
                }

                return Math.Sqrt(distance);
            }

            public void PrintArray()
            {
                Console.WriteLine();

                foreach (int number in _coordinates)
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
            }
        }
    }
}
