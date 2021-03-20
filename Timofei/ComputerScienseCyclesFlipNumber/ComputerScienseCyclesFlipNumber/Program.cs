using System;

namespace ComputerScienseCyclesFlipNumber
{
    class Program
    {
        // Вводится число, преобразовать его в другое число, цифры которого будут следовать
        // в обратном порядке по сравнению с введенным числом.
        // Пример: Входные данные 123456. Ожидаемое значение 654321.
        
        static void Main(string[] args)
        {
            // сокращенная запись Int32 - int, используем ее дабы не получить пизды)))
            int dataInput = Int32.Parse(Console.ReadLine());
            // Ошибка табуляции, Python бы тебе такого не простил!
                FlipNumberMethodOne(dataInput);
                FlipNumberMethodTwo(dataInput);
        }

        
        // Этот метод полный отстой лучше его дропнуть
        // Использование лишней переменной хотя можно было сразу в консоль выводить dataInput % 10.
        // И для чего здесь конвертация в стринг? Чтобы узнать длину числа? - ну и рофлан конеш.
        static void FlipNumberMethodOne(int dataInput)
        {
            int flipNumber = 0;
            string sizeDataInput = Convert.ToString(dataInput);
            
            
            // А можно ебануться и написать так: 
            // Console.WriteLine(Convert.ToString(dataInput).ToCharArray().Reverse().Aggregate("", (s, c) => s += c ));

            for (int i = 0; i < sizeDataInput.Length; i++)
            {
                flipNumber = dataInput % 10;
                dataInput /= 10;
                
                Console.Write($"Метод 1.: {flipNumber}");
            }
        }

        
        // Это уже красивше, но зачем flipNumber???
        // Ладно если бы ты в нем хранил полное перевернутое число, ну а так смысл??
        static void FlipNumberMethodTwo(int dataInput)
        {
            int flipNumber = 0;

            while (dataInput > 0)
            {
                flipNumber = dataInput % 10;
                dataInput /= 10;
                
                Console.Write($"Метод 2.: {flipNumber}");
            }
        }
    }
}