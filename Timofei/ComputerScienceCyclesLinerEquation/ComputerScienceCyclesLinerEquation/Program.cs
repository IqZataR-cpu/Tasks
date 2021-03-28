using System;

namespace ComputerScienceCyclesLinerEquation
{
    class Program
    {
        public const int ALL_SUBJECT = 30;
        public const int All_SUM = 100;
        public const int PRICE_PENS = 10;
        public const int PRICE_PENSIL = 5;
        public const int PRICE_ERASER = 2;
      
        static void Main(string[] args)
        {
            //Требуется определить, сколько можно преобрести ручек (по цене 10 руб.),
            //карандашей (5 руб.) и ластиков (2 руб.) на 100 рублей.
            //При этом всего предметов должно быть 30.
            
            ResultLinerEquation();
        }

        public static void ResultLinerEquation()
        {
            for (int i = 0; i < All_SUM / PRICE_PENS ; i++)
            {
                for (int j = 0; j < All_SUM / PRICE_PENSIL; j++)
                {
                    for (int k = 0; k < All_SUM / PRICE_ERASER; k++)
                    {
                        if (All_SUM == PRICE_PENS * i + PRICE_PENSIL * j + PRICE_ERASER * k && ALL_SUBJECT == i + j + k)
                        {
                            Console.WriteLine($"Количество ручек: {i} \n" +
                                              $"Количество карандашей: {j} \n" +
                                              $"Количество ластиков: {k} \n");
                        }
                    }
                }
            }
        }
    }
}