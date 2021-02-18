using System;
using System.Collections.Generic;

namespace NumMassive
{
    // В целом написано неплохо, но есть свои косяки,
    // алгоритм явно не идеален и подлежит пересмотру.
    // Поправь все комментарии и будет готово.
    // Объектно ориентированная модель состояла бы из следующих объектов:
    // Некий NumberTranslator в котором хранилась логика преобразования числа в строковый формат
    // и При вызове метода translate(number) возвращалась бы строка в виде который делает твоя прога.
    // Примерный код: 
    // NumberTranslator translator = new NumberTranslator();
    // string numberToString = translator.translate(Console.ReadLine());
    // Console.WriteLine(numberToString);
    class Program
    {
        static void Main(string[] args)
        { // Зачем здесь пустая строка перед инициализацией?

            // Сокращения обычно приводят к ухудшению читабельности кода,
            // поэтому стараемся писать полные названия
            // Только если они обще принятые или ты их везде используешь по проекту
            // В данном случае ошибка в isNumberManyOrSmall
            // Названия переменных с маленькой буквы,
            // с большой только если это очень важная сущность(класс)
            int Num, NumCategory;
            string NumInWord;
            bool isNumberManyOrSmall = false;

            // Не корректное название переменной ifNum не несет в себе смысла.
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
                // Я бы оставил здесь пустую строку разделив блок ввода и логический блок
                if (Num < 0)
                {
                    NumInWord = "минус ";
                    // Эквивалентно Num = -Num; 
                    Num *= -1;
                }
                // Магические числа в коде, лучше вынести в константы и пользоваться константами
                // const MAX_NUMBER_VALUE = 999 MIN_NUMBER_VALUE = 100; 
                isNumberManyOrSmall = Num > 999 || Num < 100;

                if (isNumberManyOrSmall)
                {
                    // тоже ненавижу это слово "соответствует",
                    // всегда когда его пишу прочитаваю вслух как дурак, чтобы не ошибиться
                    Console.WriteLine("Число не соответсвует требованию, введите другое число");
                }
            }
            while (isNumberManyOrSmall);


            NumCategory = (Num / 100) * 100;
            // Если можем то сокращаем запись Num -= NumCategory
            Num = Num - NumCategory;

            foreach (var NumStr in ifNum)
            {
                // второе условие не отражает название переменной
                bool isNumMoreThanHudred = NumCategory > 99 && NumCategory == NumStr.Key;
                if (isNumMoreThanHudred)
                {
                    // сокращаем где возможно NumInWord += NumStr.Value
                    NumInWord = NumInWord + NumStr.Value;
                    NumCategory = Num;
                }
                
                // Мне кажется название firstDecade лучше отражает смысл - субьективно
                bool isNumTens = NumCategory < 100 && NumCategory >= 11 && NumCategory < 20;

                if (isNumTens)
                {
                    if (NumCategory == NumStr.Key)
                    {
                        // сокращаем где возможно NumInWord += NumStr.Value
                        NumInWord = NumInWord + NumStr.Value;
                        Console.WriteLine(NumInWord);
                        return;
                    }
                }
                else if (NumCategory < 100)
                {
                    NumCategory = (NumCategory / 10) * 10;

                    // очень тяжело по условию понять, что это именно десятки,
                    // хорошо что ты написал это в названии переменной,
                    // иначе пришлось бы пол часа тратить только на то, чтобы понять это
                    isNumTens = NumCategory == NumStr.Key || Num == NumStr.Key;

                    if (isNumTens)
                    {
                        // сокращаем где возможно Num -= NumCategory
                        Num = Num - NumCategory;
                        // сокращаем где возможно NumInWord += NumStr.Value
                        NumInWord = NumInWord + NumStr.Value;
                    }
                }
            }

            Console.WriteLine(NumInWord);
        }
    }
}
// Твоя Ide подчеркивает некоторые косячные моменты,
// наводись мышкой и читай, примеры там где сокращения строки 140, 138 и тд