using System;


// Файл и решение с тестами названо не по конвенции
namespace ComputerScienceConditionYears
{
    // область видимости
    public class Program
    {
        public static void Main(string[] args)
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
