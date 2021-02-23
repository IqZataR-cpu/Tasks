using System;
using System.Collections.Generic;

namespace NumMassive
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxNumberValue = 999;
            const int minNumberValue = 100;
            const int eleven = 11;
            const int twenty = 20;
            int number, numberCategory;
            string numberInWord;
            bool isNumberManyOrSmall = false;

            Dictionary<int, string> arrayWordOfNumber = new Dictionary<int, string>
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
                numberInWord = "";
                Console.WriteLine("Введите трехзначное число");
                number = int.Parse(Console.ReadLine());
              
                if (number < 0)
                {
                    numberInWord = "минус ";
                    number = -number;
                }

                isNumberManyOrSmall = number > maxNumberValue || number < minNumberValue;

                if (isNumberManyOrSmall)
                {
                    Console.WriteLine("Число не удовлетворяет требованию, введите другое число");
                }
            }
            while (isNumberManyOrSmall);


            numberCategory = (number / 100) * 100;
            number -= numberCategory;

            foreach (var numberString in arrayWordOfNumber)
            {
                bool isFirstDecade = numberCategory >= minNumberValue && numberCategory == numberString.Key;

                if (isFirstDecade)
                {
                    numberInWord += numberString.Value;
                    numberCategory = number;
                }

                bool isSecondDecade = numberCategory < minNumberValue && numberCategory >= eleven && numberCategory < twenty;

                if (isSecondDecade)
                {
                    if (numberCategory == numberString.Key)
                    {
                        numberInWord += numberString.Value;
                        Console.WriteLine(numberInWord);
                        return;
                    }
                }
                else if (numberCategory < minNumberValue)
                {
                    numberCategory = (numberCategory / 10) * 10;

                    bool isNumTens = numberCategory == numberString.Key || number == numberString.Key;

                    if (isNumTens)
                    {
                        number -= numberCategory;
                        numberInWord += numberString.Value;
                    }
                }
            }
            
            Console.WriteLine(numberInWord);
        }
    }
}