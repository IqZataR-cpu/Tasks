using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение.");
            int naturalNumber = Convert.ToInt32(Console.ReadLine());
            
            // Не забываем про пустые строки после блоков цикла

            // Пока введенное число не будет равно 1 (единице), выполняем предписанные условия.
            while (naturalNumber != 1)
            {
                // Условие одной строкой лучше записывать тогда, когда
                // Не следует else после этого действия

                // Четное число всегда будет равно 1.
                if (naturalNumber % 2 == 0) naturalNumber = naturalNumber / 2;
                else
                {
                    // Необходимо преобразовать нечетное число в четное. 
                    while (naturalNumber % 2 != 0)
                    {
                        naturalNumber = (naturalNumber * 3 + 1) / 2;
                    } 
                }
            }
            Console.WriteLine(naturalNumber);
        }
    }
}