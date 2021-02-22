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

            numbers.SortDesc(); //Исправить сорт
            numbers.Print();
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
            for (int i = 0; i < this.; i++)//Отредачить
            {
                
            }
            foreach (var item in this)
            {
                
            }
        }
    }
}
            