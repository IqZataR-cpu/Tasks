using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Massive_Easy
{
    // Решил правильно, но алгоритм откровенно неверный, поэтому переделай на myArray[i - 1]
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Введите количество элементов массива: "); //Вводим количество элементов FUCK MOY MOZG!!!
            int n = int.Parse(Console.ReadLine());
            // Не выделил пробелами знаки!
            int[] myArray= new int[n-1]; //Размер массива FUCK MOY MOZG!!!

            for (int i = 0; i<myArray.Length; i++) 
            {
                myArray[i] = rand.Next(0,100); //Заполняем случайными числами FUCK MOY MOZG!!!
                Console.Write(myArray[i] + " "); // И выводим его FUCK MOY MOZG!!! FUCK MOY MOZG!!! FUCK MOY MOZG!!! FUCK MOY MOZG!!!
            }
            
            Console.WriteLine(); //Отступ, чтобы разделить от результата FUCK MOY MOZG!!! FUCK MOY MOZG!!!
            
            // зачем эта переменная, если можно проверять myArray[i - 1]???? Лишнее место в памяти!
            int firstNumber = myArray[0]; //Присваиваю переменной 1-ое значение для сравнения FUCK MOY MOZG!!! 
            
            // цикл можно стартануть с i = 1 и не будет выхода за пределы массива, если использовать myArray[i - 1]
            for (int i = 0; i < myArray.Length; i++)
            {
                // не выделил знак сравнения пробелами
                if (firstNumber<myArray[i]) //если больше, то обновление и вывод FUCK MOY MOZG!!!
                {
                    firstNumber = myArray[i];
                    Console.WriteLine(firstNumber);
                }
                else //если меньше, то только замена переменной сравнения FUCK MOY MOZG!!!
                {
                    firstNumber = myArray[i];
                }
            }
        }
    }
}
