using System;
using Practice.Figures;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle("Треугольник", 4, 2, 5);
            Tetragon tetragon = new Tetragon("Четырехугольник", 2, 3, 4, 5);
            
            triangle.Print();
            tetragon.Print();
            
            Console.WriteLine($"Площадь треугольника:{triangle.Area2}");
            Console.WriteLine($"Площадь квадрата:{triangle.Area2}");
        }
    }
}
