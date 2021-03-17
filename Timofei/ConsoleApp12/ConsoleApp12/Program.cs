using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine()); //Называй правильно переменные. Непонятно, что за a, b, c.Переменные должны называться так,
            int b = Int32.Parse(Console.ReadLine()); //чтобы было понятно, для чего они предназначены. Допустим, вместо переменной "a" ты мог бы её назвать
            int c = Int32.Parse(Console.ReadLine()); //"firstInputValue или, на крайний случай, если условием задан именно параметр a, то inputValueA
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
                else if (d > 0) //лишнее условие. У тебя и так проверилось меньше 0 и равно 0. Осталось только > 0 и это можно просто добавить как else, а не else if
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