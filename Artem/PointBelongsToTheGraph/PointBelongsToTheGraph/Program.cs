using System;

namespace PointBelongsToTheGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую координату точки: ");
            int firstCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую координату точки: ");
            int secondCoordinate = int.Parse(Console.ReadLine());

            int y = 5 * (ExponentionalNumber(firstCoordinate, 2)) - (7 * firstCoordinate) + 2;
            
            if (y == secondCoordinate)
            {
                Console.WriteLine($"График функции пересекает точку с координатами " +
                    $"({firstCoordinate}, {secondCoordinate})");
            }
            else
            {
                Console.WriteLine($"График функции не пересекает точку с координатами " +
                    $"({firstCoordinate}, {secondCoordinate})");
            }
        }

        static int ExponentionalNumber(int number, int exponent)
        {
            for (int i = 1; i <= exponent - 1 ; i++)
            {
                number *= number;
            }

            return number;
        }
    }
}
