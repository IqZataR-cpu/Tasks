using System;
using System.Collections.Generic;

namespace QueueOperation
{
    class Program
    {
        private static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            int firstElementQueue;
            Random random = new Random();
            int numbersCount;

            Console.WriteLine("Введите количество элементов очереди: ");
            numbersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numbersCount - 1; i++)
            {
                numbers.Enqueue(random.Next(100));
            }

            PrintQueue(numbers);

            firstElementQueue = numbers.Dequeue();

            PrintQueue(numbers);

            firstElementQueue = numbers.Peek();

            PrintQueue(numbers);
        }

        private static void PrintQueue(Queue<int> numbers)
        {
            Console.WriteLine("\nОчередь: ");

            foreach (var numbersItem in numbers)
            {
                Console.Write($"{numbersItem} ");
            }
        }
    }
}
