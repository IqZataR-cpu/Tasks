using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            double d;
            double x1,x2;
            
            if (a != 0)
            {
                d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine($"Корней нет");
                } 
                else if (d == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine($"x1, x2 = {x1}");
                } 
                else if (d > 0)
                {
                    x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    
                    Console.WriteLine($"x1 = {x1}");
                    Console.WriteLine($"x2 = {x2}");
                }
            }
        }
    }
}