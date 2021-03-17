using System;

namespace ConsoleApp20
{
    class Program
    {
        public const int MAXSIZEARRAY = 3;
        
        static void Main(string[] args)
        {
            int enterNumber = Int32.Parse(Console.ReadLine());
            int[] dataArray = new int[MAXSIZEARRAY];
            
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = enterNumber % 10;
                enterNumber /= 10;
            }
            
            TransformationEnterNumber(dataArray);
        }
        /// <summary>
        /// Преобразует введенное пользователем число в словесную форму.
        /// </summary>
        /// <param name="array"></param>
        static void TransformationEnterNumber(int[] array)
        {
            int numberOne = array[2];
            int numberTwo = array[1];
            int numberThree = array[0];
            bool trueNumberOne = numberOne != 0;
         
            if (trueNumberOne)
            {
                switch (numberOne)
                {
                    case 0:  break;
                    case 1: Console.Write("Сто "); break;
                    case 2: Console.Write("Двести "); break;
                    case 3: Console.Write("Триста "); break;
                    case 4: Console.Write("Четыреста "); break;
                    case 5: Console.Write("Пятьсот "); break;
                    case 6: Console.Write("Шестьсот "); break;
                    case 7: Console.Write("Семьсот "); break;
                    case 8: Console.Write("Восемьсот "); break;
                    case 9: Console.Write("Девятьсот "); break;
                }

                if (numberTwo != 1)
                {
                    switch (numberTwo)
                    {
                            
                        case 0:  break;
                        case 2: Console.Write("двадцать "); break;
                        case 3: Console.Write("тридцать "); break;
                        case 4: Console.Write("сорок "); break;
                        case 5: Console.Write("пятьсот "); break;
                        case 6: Console.Write("шестьсот "); break;
                        case 7: Console.Write("семьсот "); break;
                        case 8: Console.Write("восемьсот "); break;
                        case 9: Console.Write("девятьсот "); break;
                    }
                    switch (numberThree)
                    {
                        case 0:  break;
                        case 1: Console.Write("один."); break;
                        case 2: Console.Write("два."); break;
                        case 3: Console.Write("три."); break;
                        case 4: Console.Write("четыре."); break;
                        case 5: Console.Write("пять."); break;
                        case 6: Console.Write("шесть."); break;
                        case 7: Console.Write("семь."); break;
                        case 8: Console.Write("восемь."); break;
                        case 9: Console.Write("девять."); break;
                    }
                }
                else
                {
                    switch (numberTwo)
                    {
                        case 1: Console.Write("одинадцать."); break;
                        case 2: Console.Write("двенадцать."); break;
                        case 3: Console.Write("тринадцать."); break;
                        case 4: Console.Write("четырнадцать. "); break;
                        case 5: Console.Write("пятнадцать."); break;
                        case 6: Console.Write("шестнадцать."); break;
                        case 7: Console.Write("семнадцать."); break;
                        case 8: Console.Write("восмнадцать."); break;
                        case 9: Console.Write("девятнадцать."); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Недопустимое число!");
            }
        }
    }
}