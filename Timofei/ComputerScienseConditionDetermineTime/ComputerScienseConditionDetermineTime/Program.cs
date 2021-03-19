using System;

namespace ComputerScienseConditionDetermineTime
{
    class Program
    {
        //В переменной min лежит число от 0 до 59.
        //Определите в какую четверть часа попадает это число (в первую, вторую, третью или четвертую).
        
        private const int FIRST_QUARTER_HOUR = 15;
        private const int SECOND_QUARTER_HOUR = 30;
        private const int THIRD_QUARTER_HOUR = 45;
        private const int FOURTH_QUARTER_HOUR = 59;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минуты.");
            
            int minutesInput = Int32.Parse(Console.ReadLine());
            
            DetermineTimeMethodOne(minutesInput);
            DetermineTimeMethodTwo(minutesInput);
        }

        static void DetermineTimeMethodOne(int minutesInput)
        {
            bool validationDataInput = ((0 <= minutesInput) && (minutesInput <= 59));
            
            if (validationDataInput)
            {
                if (0 <= minutesInput && minutesInput <= FIRST_QUARTER_HOUR)
                {
                    Console.WriteLine("1/4 часа.");
                }
                if (FIRST_QUARTER_HOUR < minutesInput && minutesInput <= SECOND_QUARTER_HOUR)
                {
                    Console.WriteLine("2/4 часа.");
                }
                if (SECOND_QUARTER_HOUR < minutesInput && minutesInput <= THIRD_QUARTER_HOUR)
                {
                    Console.WriteLine("3/4 часа.");
                }
                if (THIRD_QUARTER_HOUR < minutesInput && minutesInput <= FOURTH_QUARTER_HOUR)
                {
                    Console.WriteLine("4/4 часа.");
                }
            }
            else
            {
                Console.Write("Недопустимое число!");
            }
        }
        
        static void DetermineTimeMethodTwo(int minutesInput)
        {
            bool validationDataInput = ((0 <= minutesInput) && (minutesInput <= 59));
            bool firstQuarterHour    = (0 <= minutesInput && minutesInput <= FIRST_QUARTER_HOUR);
            bool secondQuarterHour   = (FIRST_QUARTER_HOUR < minutesInput && minutesInput <= SECOND_QUARTER_HOUR);
            bool thirdQuarterHour    = (SECOND_QUARTER_HOUR < minutesInput && minutesInput <= THIRD_QUARTER_HOUR);
            bool fourthQuarterHour   = (THIRD_QUARTER_HOUR < minutesInput && minutesInput <= FOURTH_QUARTER_HOUR);

            if (validationDataInput)
            {
                if (firstQuarterHour)
                {
                    Console.WriteLine("1/4 часа.");
                }
                if (secondQuarterHour)
                {
                    Console.WriteLine("2/4 часа.");
                }
                if (thirdQuarterHour)
                {
                    Console.WriteLine("3/4 часа.");
                }
                if (fourthQuarterHour)
                {
                    Console.WriteLine("4/4 часа.");
                }
            }
            else
            {
                Console.Write("Недопустимое число!");
            }
        }
    }
}