using System;

namespace FunctionEasy
{
    // В каждом методе и поле и свойстве класса необходимо указывать область видимости.
    // Private, protected или public внезависимости где и с чем мы работаем.
    class Program
    {
        static void Main(string[] args)
        {
            // В целом можно не разделять консольный вывод и ввод Интером.
            // Единственный норм интер в этом методе 20 строка.
            Console.WriteLine("Введите число: ");

            int yourNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите степень: ");

            int degreeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"Получившиеся число: {Degree(yourNumber, degreeNumber)}");
        }

        static int Degree(int returnNumber, int degree)
        {
            int number = returnNumber;
            
            for (int i = 1; i < degree; i++)
            {
                returnNumber *= number;
            }
            
            return returnNumber;
        }
    }
}
