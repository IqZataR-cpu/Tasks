using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allinall
{
    class easyDifficultyLevel
    {
        public static void taskSelectionEZ()
        {
            string userСhoice;
            Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            while (true)
            {
                userСhoice = Console.ReadLine();

                if (userСhoice == "Условия")
                {
                    Console.WriteLine("Из двух случайных чисел, одно из которых четное, а другое нечетное, определить и вывести на экран нечетное число.");//вызов класса
                    taskOneEZ();
                }
                else if (userСhoice == "Циклы")
                {
                    Console.WriteLine("Вывести на экран ряд чисел Фибоначчи, состоящий из n элементов." +
                                            "Числа Фибоначчи – это элементы числовой последовательности" +
                                            "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, …, в которой каждое последующее число равно сумме двух предыдущих.");//вызов класса
                    taskTwoEZ();
                }
                else if (userСhoice == "Массивы")
                {
                    Console.WriteLine("Даны целочисленные массивы X и Y с разным количеством элементов. " +
                        "Найти минимальные элементы этих массивах среди элементов, имеющих четный индекс.");//вызов класса

                }
                else if (userСhoice == "Функции")
                {
                    Console.WriteLine("Вы выбрали задачу на ФУНКЦИИ.");//вызов класса
                    Console.WriteLine("Введите 2 числа.");//вызов класса
                    int result = 0;
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    taskFourEZ(firstNum, secondNum, result);

                }
                else if (userСhoice == "ВЫХОД")
                {
                    Console.WriteLine("Вы будете перенаправлены в предыдущие меню ");//вызов класса
                    Console.WriteLine("Добро пожаловать в программу, для выбора уровня сложности введите: Легки, Средний, Тяжелый, для выхода напиши ВЫХОД");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите коректные данные");
                }
            }
        }






        public static void taskOneEZ() 
        {
            Console.WriteLine("Вы выбрали задачу на УСЛОВИЯ.");
            Console.WriteLine("Введите два числа");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (firstNum % 2 == 0 && secondNum % 2 == 0)
            {
                Console.WriteLine("Оба числа Четные");
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
            else if (firstNum % 2 != 0 && secondNum % 2 != 0)
            {
                Console.WriteLine("Оба числа не Четные");
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
            else if (firstNum % 2 != 0 && secondNum % 2 == 0)
            {
                Console.WriteLine($"число {secondNum.ToString()} - четное, число {firstNum.ToString()} - нечетное,");
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
            else if (firstNum % 2 == 0 && secondNum % 2 != 0)
            {
                Console.WriteLine($"число {firstNum.ToString()} - четное, число {secondNum.ToString()} - нечетное,");
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
        }


        public static void taskTwoEZ()
        {
            Console.WriteLine("Вы выбрали задачу на ЦИКЛЫ.");
            int fibonachiNum = int.Parse(Console.ReadLine());
            int fibonachiFirst = 0;            
            int fibonachiSecond = 1;
            int fibonachiRes;
            
            for (int i = 0; i < fibonachiNum; i++)
            {
                fibonachiRes = fibonachiFirst + fibonachiSecond;
                fibonachiFirst = fibonachiSecond;
                fibonachiSecond = fibonachiRes;
                Console.WriteLine($"{fibonachiRes}, ");
            }
            Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");


        }


        public static void taskFourEZ(int firstNum, int secondNum, int result)
        {
            result = result + firstNum;
            secondNum--;
            if (secondNum != 0)
            {
                taskFourEZ(firstNum, secondNum, result);
            }
            else { Console.WriteLine($"{result}"); }
        }
    }
}
