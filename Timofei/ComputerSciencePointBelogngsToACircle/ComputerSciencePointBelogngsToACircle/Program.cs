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

            Console.WriteLine(IsPointBelongsToACircle(x,y,radiusCircle));
        }

        // Забыл область видимости указать,
        // Нет такого слова Belogins, есть Belongs.
        public static bool IsPointBelongsToACircle(int x, int y, int radiusCircle)
        {
            // Выражение возвращающие тру или фолс заменяются на однострочные.
            // return radiusCircle > Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))
            // А если радиус = расстоянию до центра?
            return radiusCircle >= Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
