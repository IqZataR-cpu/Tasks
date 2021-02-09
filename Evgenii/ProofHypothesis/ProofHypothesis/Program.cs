using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cycle_hard_
{
    class Program
    {
        static void Main(string[] args)
        {
            int enteredValue, counter;
            bool isEnteredValueEven;  

            Console.Write("Введите число: ");

            enteredValue = int.Parse(Console.ReadLine());
            // Более корректный способ объявить начальное значение сразу при инициализации 
            // int counter = 0;
            counter = 0;
            
            while (enteredValue != 1)
            {
                // на заметку - это условие можно записать так !(enteredValue % 2)
                isEnteredValueEven = enteredValue % 2 == 0; 
                counter++;
                
                Console.Write($"Преобразование из числа {enteredValue} в число ") ;

                // В следующий раз сделай из этого функцию, чтобы избежать дублирования кода.
                // Абстрактный пример будет ниже
                if (isEnteredValueEven)
                {
                    // сокращенная запись выглядит лучше enteredValue /= 2;
                    enteredValue = enteredValue / 2;
                    Console.WriteLine($"{enteredValue}");
                    continue;
                }
                
                enteredValue = (enteredValue * 3 + 1) / 2;

                Console.WriteLine($"{enteredValue}");
            }
            Console.WriteLine($"Количество преобразований: {counter}");
            Console.ReadLine();
        }

        // примерный отрывок кода позволяющий убрать continue
        // примерно так выглядит стратегия без использования классов
        // примерно так выглядит сокрытие данных,
        // ты не показываешь логику программы разбивая ее на мелкие понятные для чтения отрывки
        private static void program()
        {
            int enteredValue = 12;
            bool isEnteredValueEven = enteredValue % 2 == 0;

            enteredValue = changeValueByType(enteredValue, isEnteredValueEven);
            Console.WriteLine($"{enteredValue}");
        }

        private static int changeValueByType(int value, bool isEven)
        {
            if (isEven)
            {
                return changeEvenValue(value);
            }

            return changeOddValue(value);
        }
        
        private static int changeOddValue(int value)
        {
            return (value * 3 + 1) / 2;
        }
        
        private static int changeEvenValue(int value)
        {
            return value / 2;
        }
    }
}

