﻿using System;

namespace ComputerScienceArrayTaskOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести элементы числового массива, которые больше, чем элементы, стоящие перед ними.
            
            int[] arrayInput = new int[] {3, 9, 8, 4, 5, 1, 5, 6};

            for (int i = 1; i < arrayInput.Length; i++)
            {   
                // забыл "-" с двух сторон запятыми выделить.
                if (arrayInput[i - 1] < arrayInput[i])
                { 
                    Console.Write($"{arrayInput[i]} "); ;
                }
            }
        }
    }
}
