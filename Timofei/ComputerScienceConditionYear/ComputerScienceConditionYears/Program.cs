using System;

// Я в беседу заливал файл .gitignore,
// чтобы не грузить лишние файлы в гит его нужно помещать в каждый проект
// чуть позже сделаю один .gitignore, чтобы этого не делать.
// Файл и решение с тестами названо не по конвенции
namespace ComputerScienceConditionYears
{
    // область видимости
    class Program
    {
         // область видимости
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
