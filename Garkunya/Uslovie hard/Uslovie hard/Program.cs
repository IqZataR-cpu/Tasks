using System;

namespace Uslovie_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1 сторону треугольника: ");
            int firstSide = int.Parse(Console.ReadLine());
            
            Console.Write("Введите 2 сторону треугольника: ");
            int secondSide = int.Parse(Console.ReadLine());
            
            Console.Write("Введите 3 сторону треугольника: ");
            int thirdSide = int.Parse(Console.ReadLine());

            if (firstSide == 0 || secondSide == 0 || thirdSide == 0)
            {
                Console.Write("Сторона введена не корректно!");
            }
                else if ((firstSide + secondSide) < thirdSide || (firstSide + thirdSide) < secondSide || (secondSide + thirdSide) < firstSide)
                {
                    Console.WriteLine("Такого треугольника не существует!");
                }
                    else if (firstSide == secondSide && firstSide == thirdSide && secondSide == thirdSide)
                    {
                        Console.WriteLine("Треугольник равносторонний!");
                    }
                        else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
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
