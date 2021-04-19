using System;

namespace QuarterHour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int min;
            // Это можно не хранить в памяти =)
            string quarter = null;

            Console.WriteLine($"Сейчас {min = DefinitionMinute()} минут, {quarter = QuarterHour(min)} четверть часа");
        }

        private static int DefinitionMinute()
        {
            int minute;
            Random random = new Random();

            return minute = random.Next(0, 60);
        }

        private static string QuarterHour(int minute)
        {
            string quarter = null;

            if (minute <= 15)
            {
                return quarter = "первая";
            }
            // первое условие бесполезное
            else if (minute > 15 && minute <= 30)
            {
                return quarter = "вторая";
            }
            // первое условие бесполезное
            else if (minute > 30 && minute <= 45)
            {
                return quarter = "третья";
            }
            // первое условие бесполезное
            else if (minute > 45 && minute <= 59)
            {
                return quarter = "четвертая";
            }

            return quarter;
        }
    }
}
