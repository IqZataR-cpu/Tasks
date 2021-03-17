using System;

namespace Uslovie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            int i = rnd.Next(0,10);
            
            if (i % 2 == 0)
            {
                Console.WriteLine("Четное!");
            } else {
                Console.WriteLine("Нечетное!");
            }
        }
    }
}