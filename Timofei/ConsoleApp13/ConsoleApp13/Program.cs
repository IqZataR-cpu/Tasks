using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задайте число");
            string setNumber = Console.ReadLine();
            
            Console.WriteLine($"Задайте цифру которую необходимо удалить");
            string deleteNumber = Console.ReadLine();
            
            Console.WriteLine($"____________________");
            for (int i = 0; i < setNumber.Length; i++)
            {
                if (Convert.ToChar(deleteNumber) != Convert.ToChar(setNumber[i]))
                {
                    Console.Write(setNumber[i]);
                }
            }
        }
    }
}