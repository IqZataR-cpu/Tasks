using System;

namespace condition_Medium_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int min = rnd.Next(0, 59); //получаем случайное число

            if (min>=0 && min <15) //проверяем условие и выводим
            {
                Console.Write($"{min} минут находятся в 1-ой четверти часа");
            }
            else if (min>=15 && min <30)
            {
                Console.Write($"{min} минут находятся в 2-ой четверти часа");
            }
            else if (min>=30 && min <45)
            {
                Console.Write($"{min} минут находятся в 3-ой четверти часа");
            }
            else
            {
                Console.Write($"{min} минут находятся в 4-ой четверти часа");
            }
        }
    }
}