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
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Введите количество элементов массива: "); //Вводим количество элементов
            int n = int.Parse(Console.ReadLine());
            int[] myArray= new int[n-1]; //Размер массива

            for (int i = 0; i<myArray.Length; i++) 
            {
                myArray[i] = rand.Next(0,100); //Заполняем случайными числами
                Console.Write(myArray[i] + " "); // И выводим его
            }
            
            Console.WriteLine(); //Отступ, чтобы разделить от результата
            
            int firstNumber = myArray[0]; //Присваиваю переменной 1-ое значение для сравнения
            
            for (int i = 0; i < myArray.Length; i++)
            {
                if (firstNumber<myArray[i]) //если больше, то обновление и вывод
                {
                    firstNumber = myArray[i];
                    Console.WriteLine(firstNumber);
                }
                else //если меньше, то только замена переменной сравнения
                {
                    firstNumber = myArray[i];
                }
            }
        }
    }
}