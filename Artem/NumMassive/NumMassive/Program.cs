using System;
using System.Collections.Generic;

namespace NumMassive
{
    class Program
    {
        static void Main(string[] args)
        {

            int Num, NumCategory;
            string NumInWord;
            bool isNumberManyOrSmall = false;

            Dictionary<int, string> ifNum = new Dictionary<int, string>
            {
                {100, "cто "},
                {200, "двести "},
                {300, "триста "},
                {400, "сетыреста "},
                {500, "пятьсот "},
                {600, "шестьсот "},
                {700, "семьсот "},
                {800, "восемьсот "},
                {900, "девятьсот "},
                {11, "одиннадцать" },
                {12, "двенадцать" },
                {13, "тринадцать" },
                {14, "четырнадцать" },
                {15, "пятнадцать" },
                {16, "шестьнадцать" },
                {17, "семьнадцать" },
                {18, "восемьнадцать" },
                {19, "девятнадцать" },
                {10, "десять " },
                {20, "двадцать " },
                {30, "тридцать " },
                {40, "сорок " },
                {50, "пятьдесят " },
                {60, "шестьдесят " },
                {70, "семьдесят " },
                {80, "восемьдесят " },
                {90, "девяносто " },
                {1 , "один" },
                {2 , "два" },
                {3 , "три" },
                {4 , "четыре" },
                {5 , "пять" },
                {6 , "шесть" },
                {7 , "семь" },
                {8 , "восемь" },
                {9 , "девять" }
            };

            do
            {
                NumInWord = "";
                Console.WriteLine("Введите трехзначное число");
                Num = int.Parse(Console.ReadLine());
                if (Num < 0)
                {
                    NumInWord = "минус ";
                    Num *= -1;
                }
                isNumberManyOrSmall = Num > 999 || Num < 100;

                if (isNumberManyOrSmall)
                {
                    Console.WriteLine("Число не соответсвует требованию, введите другое число");
                }
            }
            while (isNumberManyOrSmall);


            NumCategory = (Num / 100) * 100;
            Num = Num - NumCategory;

            foreach (var NumStr in ifNum)
            {
                bool isNumMoreThanHudred = NumCategory > 99 && NumCategory == NumStr.Key;
                if (isNumMoreThanHudred)
                {
                    NumInWord = NumInWord + NumStr.Value;
                    NumCategory = Num;
                }

                bool isNumTens = NumCategory < 100 && NumCategory >= 11 && NumCategory < 20;

                if (isNumTens)
                {
                    if (NumCategory == NumStr.Key)
                    {
                        NumInWord = NumInWord + NumStr.Value;
                        Console.WriteLine(NumInWord);
                        return;
                    }
                }
                else if (NumCategory < 100)
                {
                    NumCategory = (NumCategory / 10) * 10;

                    isNumTens = NumCategory == NumStr.Key || Num == NumStr.Key;

                    if (isNumTens)
                    {
                        Num = Num - NumCategory;
                        NumInWord = NumInWord + NumStr.Value;
                    }
                }
            }

            Console.WriteLine(NumInWord);
        }
    }
}
