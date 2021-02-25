using System;
using System.Collections.Generic;
using System.Linq;

namespace classesHard
{

    class Program
    {
        private static ExtendedList numbers = new ExtendedList() { 4, 6, 1, 6, 2, 1, 9, 2 };
                 
        static void Main(string[] args)
        {
            numbers.Print();

            OutputMinMax(numbers);            
            SearchIndex();
            SortList();
            FlipArray();
            PrintCountEvenOdd();
        }

        public static void OutputMinMax(ExtendedList numbers)
        {
            Console.WriteLine($"\nМаксимальное значение массива: {numbers.Max()}");

            Console.WriteLine($"Минимальное значение массива: {numbers.Min()}\n");
        }        
        
        static void SearchIndex()
        {
            Console.Write("\nВведите значение массива: ");

            int inputValue = int.Parse(Console.ReadLine());

            Console.WriteLine($"Значение находится в массиве под индексом {numbers.IndexOf(inputValue)}");
        }
        
        static void SortList()
        {
            Console.WriteLine("\nСортируем по возрастанию");

            numbers.Sort();
            numbers.Print();

            Console.WriteLine("\nСортируем по убыванию");

            numbers.SortDesc(); 
            numbers.Print();
        }

        static void FlipArray()
        {
            Console.WriteLine("\nПереворачиваем массив");
            numbers.Reverse();
            numbers.Print();
        } 

        static void PrintCountEvenOdd()
        {
            Console.WriteLine($"\nЧисло чётных чисел в массиве: {numbers.CountEven()}");
            Console.WriteLine($"\nЧисло нечётных чисел в массиве: {numbers.CountOdd()}");    
        }
    }

    public class ExtendedList : List<int>
    {
        public void Print()
        {
            Console.Write($"Массив: ");

            foreach (var item in this)
            {
                Console.Write(item);
            }
        }

        public void SortDesc() 
        {
            int temp;
            for (int i = 0; i < this.Count; i++)
            {
                for (int j = i + 1; j < this.Count; j++)
                {
                    if (this[i] < this[j])
                    {
                        temp = this[i];
                        this[i] = this[j];
                        this[j] = temp;
                    }
                }
            }
        }
        
        public int CountEven()
        {
            int countEvenValues = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] % 2 == 0)
                {
                    countEvenValues += 1;
                }
            }
            return countEvenValues;
        }

        public int CountOdd()
        {
            int countOddValues = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i] % 2 == 1)
                {
                    countOddValues += 1;
                }
            }
            return countOddValues;
        }
    }
}
            