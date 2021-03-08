using System;

namespace Uslovie_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 сторону треугольника: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Введите 2 сторону треугольника: ");
            int b = int.Parse(Console.ReadLine());
            
            Console.Write("Введите 3 сторону треугольника: ");
            int c = int.Parse(Console.ReadLine());

            if (((a + b) < c) || ((a + c) < b) || ((b + c) < a))
            {
                Console.WriteLine("Такого треугольника не существует!");
            }
            else
            {
                if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("Треугольник равносторонний!");
                }
                else
                {
                    if ((a == b) || (a == c) || (b == c))
                    {
                        Console.WriteLine("Треугольник равнобедренный!");
                    }
                    else
                    {
                        Console.WriteLine("Треугольник разносторонний!");
                    }
                }
            }
        }
    }
}