﻿using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения сторон треугольника:");
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B= ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("C= ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            // Проверка на существование треугольника.
            bool existenceTriangle = (((a + b) < c)) || ((a + c) < a) || ((b + c) < b);
            // Проверка является ли треугольник равносторонним.
            bool equilateralTriangle = ((a == b) && (b == c) && (a == c));
            // Проверка является ли треугольник разносторонним.
            bool versatileTriangle = ((a != b) && (c != a) && (b != c));
            // Проверка является ли треугольник равнобедренным.
            bool isoscelesTriangle = ((a == b) && (b != c) && (a != c) || 
                                      (b == c) && (b != a) && (c != a) || 
                                      (a == c) && (b != c) && (b != c) || 
                                      (b == c) && (b != a) && (c != a));
            
            if (existenceTriangle)
            {
                Console.WriteLine("Треугольник не существует.");
            }
             else
            {
                if (equilateralTriangle) Console.WriteLine("Равносторонний треугольник.");
                if (versatileTriangle)   Console.WriteLine("Разносторонний треугольник.");
                if (isoscelesTriangle)   Console.WriteLine("Равнобедренный треугольник.");
            }
        }
    }
}
