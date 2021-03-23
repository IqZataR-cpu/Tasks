using System;

namespace condition_Medium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int minuteValue = rnd.Next(0, 59);

            if (minuteValue >= 0 && minuteValue < 15)
            {
                Console.Write($"{ minuteValue } минут находятся в 1-ой четверти часа");
            }
            else if (minuteValue >= 15 && minuteValue < 30)
            {
                Console.Write($"{ minuteValue } минут находятся в 2-ой четверти часа");
            }
            else if (minuteValue >= 30 && minuteValue < 45)
            {
                Console.Write($"{ minuteValue } минут находятся в 3-ой четверти часа");
            }
            else
            {
                Console.Write($"{ minuteValue } минут находятся в 4-ой четверти часа");
            }
        }
    }
}