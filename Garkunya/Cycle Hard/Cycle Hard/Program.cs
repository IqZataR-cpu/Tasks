using System;

namespace Cycle_Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое натуральное число: ");
            
            int divisibleNumber = int.Parse(Console.ReadLine());
            int y = 0;
            int countTrys = 0;

                while (y == 0)
                {
                    if (divisibleNumber == 2)
                    {
                        y++;
                        countTrys++;
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
                
                Console.WriteLine("Получилось!");
                Console.WriteLine("Количество операций: {0}", countTrys);
                }
        }
    }
