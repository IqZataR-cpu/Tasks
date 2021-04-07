using System;

namespace ComputerScienceConditionYears
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputYear = int.Parse(Console.ReadLine());
            string result = ValidLeapYear.LeepYear(inputYear);
            
            Console.WriteLine(result);
        }
    }

    public class ValidLeapYear
    {
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