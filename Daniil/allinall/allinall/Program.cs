﻿using System;
// Избавляемся от ненужных импортов
using System.Collections.Generic;

// Названия папок и соответственно namespace с большой буквы
// Разделяй логические блоки интерами
// Обобщенный пример:
// Инициализация переменных типо int i;
// Enter
// Логика ввода данных i = Console.ReadLine();
// Enter
// Логика вычислений/условий, в общем решение конкретной проблемы/задачи
// Enter
// Вывод или возвращаемое значение
// Те же правила работают в этих блоках, если их можно логически разделить - разделяем.
namespace allinall
{
    
    // Обращай внимание на грамотность,
    // либо пиши текст на английском через переводчик, чтобы не ошибаться
    // в нормальной компании за такое тебя выкинут, скорее всего.
    // Грамматических ошибок максимум - 5%, иначе с этим нельзя работать
    class Program
    {
        static void Main(string[] args)
        {
            
            string userСhoice;
            // Можно было разделить этот текст на два, 
            // Вначале вывести "Добро пожаловать в программу"
            // А в цикле "для выбора уровня....",
            // Это позволило бы не дублировать код в самом классе с заданиями
            // Также не стоит делать строку слишком длинной, делай переносы, пример ниже
            Console.WriteLine("Добро пожаловать в программу, для выбора уровня сложности введите:" +
                              " Легки, Средний, Тяжелый, для выхода напиши ВЫХОД");
            

            while (true)
            {
                userСhoice = Console.ReadLine();
                
                // Нет смысла в такой штуке, скину пример, который позволит упростить синтаксис до 1 строки.
                if (userСhoice == "Легкий")
                {
                    EasyDifficultyLevel.TaskSelectionEZ();//вызов класса
                }
                // Нет смысла дублировать "введите корректные данные",
                // в крайнем случае можно было добавить все в один if снизу,
                // а вообще это можно просто удалить и ничего не случится
                else if (userСhoice == "Тяжелый")
                {
                    Console.WriteLine("Введите коректные данные22");//вызов класса
                }
                // Тоже самое что и "Тяжелый"
                else if (userСhoice == "Средний")
                {
                    Console.WriteLine("Введите коректные данные333");//вызов класса
                }
                else if (userСhoice == "ВЫХОД")
                {
                    Console.WriteLine("Спасибо за использование програамы ");//вызов класса
                    break;
                }
                else
                {
                    Console.WriteLine("Введите коректные данные");
                }
                // Зачем здесь пустые строки?


            }
            // А тут?



        }
        // ?

    
    
    
    
    
    
    }
}