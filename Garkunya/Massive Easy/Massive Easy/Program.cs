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

            Console.Write("Введите количество элементов массива: ");
            int inputValue = int.Parse(Console.ReadLine());
            int[] myArray= new int[inputValue - 1];
            // тут лучше поставить enter
            for (int i = 0; i < myArray.Length; i++) 
            {
                myArray[i] = rand.Next(0, 100);
                
                Console.Write(myArray[i] + " ");
            }
            
            Console.WriteLine();
            // Ошибка табуляции. Python бы тебе такое не простил.
           for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i - 1] < myArray[i])
                {
                    Console.WriteLine(myArray[i]);
                }
            }
        }
    }
}
