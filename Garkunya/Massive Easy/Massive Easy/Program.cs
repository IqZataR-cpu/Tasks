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
            int n = int.Parse(Console.ReadLine());
            int[] myArray= new int[n - 1];

            for (int i = 0; i<myArray.Length; i++) 
            {
                myArray[i] = rand.Next(0,100);
                Console.Write(myArray[i] + " ");
            }
            
            Console.WriteLine();
            
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
