using System;

namespace condition_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число = "); 
            int n = int.Parse(Console.ReadLine());

            if (n == 10)
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }
    }
}