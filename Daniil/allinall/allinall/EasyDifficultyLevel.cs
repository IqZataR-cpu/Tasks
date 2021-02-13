using System;
// Избавляемся от ненужных импортов
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allinall
{
    class EasyDifficultyLevel
    {
        public static void TaskSelectionEZ()
        {
            string userСhoice;
            // Тоже самое, что в классе Program, можно было разделить и не дублировать.
            // Длинная строка
            Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            while (true)
            {
                userСhoice = Console.ReadLine();

                // Используя стратегию и полиморфизм подтипов, можно избежать многократного if else...
                if (userСhoice == "Условия")
                {
                    // Длинная строка
                    Console.WriteLine("Из двух случайных чисел, одно из которых четное, а другое нечетное, определить и вывести на экран нечетное число.");//вызов класса
                    DeterminesParityOfNum();
                }
                else if (userСhoice == "Циклы")
                {
                    Console.WriteLine("Вывести на экран ряд чисел Фибоначчи, состоящий из n элементов." +
                                            "Числа Фибоначчи – это элементы числовой последовательности" +
                                            // Длинная строка
                                            "0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, …, в которой каждое последующее число равно сумме двух предыдущих.");//вызов класса
                    ListOfFibonacci();
                }
                else if (userСhoice == "Массивы")
                {
                    Console.WriteLine("Даны целочисленные массивы X и Y с разным количеством элементов. " +
                                      // Длинная строка
                                      "Найти минимальные элементы этих массивах среди элементов, имеющих четный индекс.");//вызов класса

                }
                else if (userСhoice == "Функции")
                {
                    Console.WriteLine("Вы выбрали задачу на ФУНКЦИИ.");//вызов класса
                    Console.WriteLine("Введите 2 числа.");//вызов класса
                    int result = 0;
                    int firstNum = int.Parse(Console.ReadLine());
                    int secondNum = int.Parse(Console.ReadLine());
                    MultiplicationWithRecursion(firstNum, secondNum, result);
                    // Длинная строка + дублирование
                    Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
                }
                else if (userСhoice == "ВЫХОД")
                {
                    Console.WriteLine("Вы будете перенаправлены в предыдущие меню ");//вызов класса
                    // Длинная строка + дублирование
                    Console.WriteLine("Добро пожаловать в программу, для выбора уровня сложности введите: Легки, Средний, Тяжелый, для выхода напиши ВЫХОД");
                    break;
                }
                else
                {
                    Console.WriteLine("Введите коректные данные");
                }
            }
        }






        public static void DeterminesParityOfNum() 
        {
            Console.WriteLine("Вы выбрали задачу на УСЛОВИЯ.");
            // Введите два числа(одно) - неверная формулировка.
            Console.WriteLine("Введите два числа"); 
            int firstNum = int.Parse(Console.ReadLine());
            
            // Можно добавить вспомогательную функцию,
            // которая определит тип числа и выведет, позволит избавиться от else.
            // Либо через полиморфизм подтипов, но это сложно. 
            if (firstNum % 2 != 0)
            {
                Console.WriteLine($"число {firstNum.ToString()} - нечетное");
                // Длинная строка + дублирование
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
            else 
            {
                Console.WriteLine($"число {firstNum.ToString()} - четное");
                // Длинная строка + дублирование
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            }
        }

        // Пример функции выводящей тип и возвращающей число
        private static int PrintType(int number)
        {
            if (number % 2 != 0)
            {
                PrintEven(number);
                // Длинная строка + дублирование
                Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");

                return number;
            }
            
            PrintOdd(number);
            // Длинная строка + дублирование
            Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            
            return number;
        }
        private static void PrintEven(int number)
        {
            Console.WriteLine($"число {number.ToString()} - нечетное");
        }
        private static void PrintOdd(int number)
        {
            Console.WriteLine($"число {number.ToString()} - нечетное");
        }
        


        public static void ListOfFibonacci()
        {
            Console.WriteLine("Вы выбрали задачу на ЦИКЛЫ.");
            int fibonachiNum = int.Parse(Console.ReadLine());
            int fibonachiFirst = 0;            
            int fibonachiSecond = 1;
            int fibonachiRes;
            
            // Можно сделать с помощью 2 переменных, 3 - не нужна
            for (int i = 0; i < fibonachiNum; i++)
            {
                fibonachiRes = fibonachiFirst + fibonachiSecond;
                fibonachiFirst = fibonachiSecond;
                fibonachiSecond = fibonachiRes;
                Console.WriteLine($"{fibonachiRes}, ");
            }
            // Длинная строка + дублирование
            Console.WriteLine("Вы выбрали Легкую сложность для выбора задачи напишите: Условия, Циклы, Массивы, Функции, для выхода напиши ВЫХОД");
            // Что за пустые пространства???

        }


        // Можно сделать не используя 3 переменную,
        // подумай иначе нет смысла в рекурсии
        //  if (b == 1)
        //      return a;
        //  else
        //      return a + umnoj2(a, b-1);
        // 
        public static void MultiplicationWithRecursion(int firstNum, int secondNum, int result)
        {
            firstNum += firstNum;
            secondNum--;
            if (secondNum != 0)
            {
                MultiplicationWithRecursion(firstNum, secondNum, result);
            }
            else { Console.WriteLine($"{firstNum}"); }
        }
    }
}
