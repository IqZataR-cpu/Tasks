using System;

namespace Cycle_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число: ");
            
            int divisibleNumber = int.Parse(Console.ReadLine());
            int ready = 0;
            int countTrys = 0;

            if (divisibleNumber == 0)
            {
                Console.WriteLine("Нельзя преобразовать 0!");
            }
            else
            {
               while (ready == 0)
               {
                   if (divisibleNumber == 2)
                   {
                       ready++;
                       countTrys++;
                       Console.WriteLine("Получилось!");
                       Console.WriteLine("Количество операций: {0}", countTrys);
                   }
                   else if (divisibleNumber % 2 == 0)
                   {
                       divisibleNumber = divisibleNumber / 2;
                       countTrys++;
                   }
                   else
                   {
                       divisibleNumber = (divisibleNumber * 3 + 1) / 2;
                       countTrys++;
                   }
               }
            }
        }
    }
}
