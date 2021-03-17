using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте число");
            string setNumber = Console.ReadLine();
            
            Console.WriteLine($"Задайте цифру которую необходимо удалить");
            string deleteNumber = Console.ReadLine();
            
            Console.WriteLine();
            
            for (int i = 0; i < setNumber.Length; i++)
            {
                bool isNotExistNumberInString = Convert.ToChar(deleteNumber) != Convert.ToChar(setNumber[i]);
               
             if (isNotExistNumberInString)
                {
                    Console.Write(setNumber[i]);
                }
            }
        }
    }
}