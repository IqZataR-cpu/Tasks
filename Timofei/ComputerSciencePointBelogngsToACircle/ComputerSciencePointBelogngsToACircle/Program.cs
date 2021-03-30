using System;

namespace ComputerSciencePointBelogngsToACircle
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коородинаты: ");
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            
            Console.Write("Введите радиус круга: ");
            int radiusCircle = int.Parse(Console.ReadLine());

            Console.WriteLine(PointBeloginsToACircleValid(x,y,radiusCircle));
        }

        static bool PointBeloginsToACircleValid(int x, int y, int radiusCircle)
        {
            if (radiusCircle > Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)))
            {
                return true;
            }

            return false;
        }
    }
}