using System;

namespace QuarterHour
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int min;
            string quarter = null;

            Console.WriteLine($"Сейчас {min = DefinitionMinute()} минут, {quarter = QuarterHour(min)} четверть часа");
        }

        private static int DefinitionMinute()
        {
            int minute;
            Random random = new Random();

            minute = random.Next(0, 60);

            return minute;
        }

        private static string QuarterHour(int minute)
        {
            string quarter = null;

            if (minute <= 15)
            {
                return quarter = "первая";
            }
            else if (minute > 15 && minute <= 30)
            {
                return quarter = "вторая";
            }
            else if (minute > 30 && minute <= 45)
            {
                return quarter = "третья";
            }
            else if (minute > 45 && minute <= 59)
            {
                return quarter = "четвертая";
            }

            return quarter;
        }
    }
}
