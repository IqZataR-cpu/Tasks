using System;

namespace Massive_Medium_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.Write("Введите количество элементов массива: ");
            
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int countNumber = 0;
            float sumNumber = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = rnd.Next(0, 100);
                Console.Write(myArray[i] + " ");
            }
            
            Console.WriteLine(); 

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0 && i % 2 != 0)
                {
                    sumNumber += myArray[i];
                    countNumber++;
                }
            }

            Console.WriteLine($"Среднее арифметическое {countNumber} чисел = {sumNumber / countNumber}");
        }
    }
}
