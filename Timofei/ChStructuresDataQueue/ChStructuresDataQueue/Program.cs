using System;
using System.Collections.Generic;

namespace ChStructuresDataQueue
{
    class Program
    {
        // Указать область видимости методов и класса.
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();

            GetInsertObjectToQueue(que);
            
            PrintQueue(que);
        }
        
        // Удаляет объект из очереди и возвращает его.
        static void GetFirstObjectQueueAndDeleteHim(Queue<string> que)
        {
            Console.WriteLine($" {que.Dequeue()}");
        }
        
        // Выводит объект находящийся в начале очереди.
        static void GetFirstObjectQueue(Queue<string> que)
        {
            Console.WriteLine($" {que.Peek()}"); 
        }
        
        // Возращает объекты добавленные в очередь.
        static void GetInsertObjectToQueue(Queue<string> que)
        {
            que.Enqueue("Дарова, Михаил");
            que.Enqueue("Очереди это очень интересная вещь");
            que.Enqueue("Рекомендую к использованию!!!"); 
        }

       // Очередь работает по принципу первый вошел - первый вышел.
        static void PrintQueue(Queue<string> que)
        {
            foreach (var print in que)
            {
                Console.WriteLine(print);
            }
        }
    }
}
