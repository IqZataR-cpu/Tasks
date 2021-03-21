using System;

namespace Cycle_Easy_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int temp = 0;
            int countRemain=0;
            int countNoRemain=0;
            
            while (n>0)
            {
                temp = n % 10; //получаем остаток от деления на 10
                n /= 10; //отнимаем 1 знак слева от числа
                if (temp%2==0) //если четное - дополняем счетчик четных чисел
                {
                    countRemain++;
                }
                else //если нечетное - дополняем счетчик нечетных чисел
                {
                    countNoRemain++;
                }
            }

            Console.WriteLine($"Количество счетных чисел: {countRemain}"); //выводим значения счетчиков
            Console.WriteLine($"Количество счетных чисел: {countNoRemain}");
        }
    }
}