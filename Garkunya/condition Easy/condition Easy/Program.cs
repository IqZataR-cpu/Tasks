using System;

namespace condition_Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число = "); 
            int n = int.Parse(Console.ReadLine()); //вводим переменную

            if (n==10) //сравниваем с условием и выводим в зависимости от результата
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