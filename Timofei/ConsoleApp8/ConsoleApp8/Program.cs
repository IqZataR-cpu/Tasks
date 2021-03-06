using System;

namespace ConsoleApp8
{
    class Program
    {
        private int _campot;
        public int Campot => _campot;
        
        public static void Main(string[] args)
        { 
            Random rnd = new Random();

            int[] arrayOne = new int[rnd.Next(1,10)]; 
            int[] arrayTwo = new int[rnd.Next(1,10)];
            
            arrayOne = Functions.FillArray(arrayOne);
            arrayTwo = Functions.FillArray(arrayTwo);
            
            Console.WriteLine($"Минимальный четный элемент первого массива равен - {Functions.FindMinimum(arrayOne)}");
            Console.WriteLine($"Минимальный четный элемент второго массива равен - {Functions.FindMinimum(arrayTwo)}");
        }
    }
}