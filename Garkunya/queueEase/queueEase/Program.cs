using System;
using System.Collections;
using System.Collections.Generic;

namespace queueEase
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <int> numbers = new Queue <int> ();
            
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);

            Console.Write("Изначально очередь выглядит так: ");
            
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            int firstElement = numbers.Dequeue();

            Console.WriteLine($"\nБерем первый элемент и удаляем его: {firstElement}");
            Console.Write("Теперь очередь выглядит так: ");
            
            foreach (var item in numbers)
            {
                Console.Write(item);
            }

            Console.WriteLine($"\nБерем первый элемент, но не удаляем: {numbers.Peek()}");
            Console.Write("Очередь остается такой же: ");
            
            foreach (var item in numbers)
            {
                Console.Write(item);
            }
        }
    }
}