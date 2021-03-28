using System;

namespace ComputerScienceCyclesLinerEquation
{
    class Program
    {
        public const int COUNT_OBJECT = 30;
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
                        // Поскольку нам заранее известна сумма под которую рассчитываем,
                        // мы можем перенести расчеты по функциям и назвать их бизнес логическими именами,
                        // при прочтении которых мы сможем понять смысл текущих выражений в скобках сразу - не думая
                        // таким образом мы увеличим прозрачность кода.
                        
                        if (isAmountValid(i, j, k) && isCountObjectValid(i, j, k)) 
                        {
                            Console.WriteLine($"Количество ручек: {i} \n" +
                                              $"Количество карандашей: {j} \n" +
                                              $"Количество ластиков: {k} \n");
                        }
                    }
                }
            }
        }
        
        public static bool isAmountValid(int i, int j, int k)
        {
            return All_SUM == PRICE_PENS * i + PRICE_PENSIL * j + PRICE_ERASER * k;
        }

        public static bool isCountObjectValid(int i, int j, int k)
        {
            return COUNT_OBJECT == i + j + k;
        }
    }
}
