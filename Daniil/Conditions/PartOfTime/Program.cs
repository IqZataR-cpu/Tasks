using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionsTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = -1;
            bool isTimeValid = true;

            while (isTimeValid)
            {
                Console.WriteLine("Введите число");
                min = Convert.ToInt32(Console.ReadLine());

                if (min >= 0 && min <= 59)
                {
                    isTimeValid = false;
                }
            }

            if (min <= 15) 
            {
                Console.WriteLine("Число входит в первую четверть часа"); 
            }
            else if (min <= 30) 
            {
                Console.WriteLine("Число входит в вторую четверть часа"); 
            }
            else if (min <= 45) 
            {
                Console.WriteLine("Число входит в третью четверть часа"); 
            }
            else 
            {
                Console.WriteLine("Число входит в четвертую четверть часа");
            }

            Console.ReadKey();
        }
    }
}
