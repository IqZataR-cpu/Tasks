using System;

namespace ComputerScienceConditionYears
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());
            string result = LeepYear(inputYear);
            
            Console.WriteLine(result);
        }
        
        public static string LeepYear(int data)
        {
            if (data % 4 == 0)
            {
                return "Високосный год";
            }
            
            return "Обычный год";
        }
    }
}
