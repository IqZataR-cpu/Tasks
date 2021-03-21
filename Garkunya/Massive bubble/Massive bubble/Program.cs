using System;

namespace Massive_bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = new int[] {4, 7, 2, 3, 9, 8, 0, 1, 5, 6}; // заранее известный массив
            int temp; //переменная для сравнения

            for (int i = 0; i < someArray.Length; i++)
            {
                for (int j = i + 1; j < someArray.Length; j++)
                {
                    if (someArray[i] > someArray[j]) //сравниваем соседние переменные и меняем их местами
                    {                               // в случае успеха
                        temp = someArray[i];
                        someArray[i] = someArray[j];
                        someArray[j] = temp;
                    }                   
                }            
            }
            
            for (int i = 0; i < someArray.Length; i++) //выводим массив
            {
                Console.Write(someArray[i] + " ");
            } 

        }
    }
}