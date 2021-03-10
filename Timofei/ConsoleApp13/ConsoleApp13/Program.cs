using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Знак $ используется, когда ты хочешь вывести
            // Значение какой-то переменной помимо текста
            Console.WriteLine($"Задайте число");
            string setNumber = Console.ReadLine();
            
            Console.WriteLine($"Задайте цифру которую необходимо удалить");
            string deleteNumber = Console.ReadLine();

            // Зачем вообще эта строка снизу???
            // Если ты хотел разделить текста друг от друга
            // То используй cтроковый литерал \n
            Console.WriteLine($"____________________");
            // Не забываем разделять логические блоки 
            // В программе пустыми строками
            for (int i = 0; i < setNumber.Length; i++)
            {
                // Чтобы было понятней, что конкретно проверяется
                // В условии используй переменную типо bool
                // И припиши значение условия ей
                // Например, bool isNotExistNumberInString =
                // = Convert.ToChar(deleteNumber) != Convert.ToChar(setNumber[i])
                if (Convert.ToChar(deleteNumber) != Convert.ToChar(setNumber[i]))
                {
                    Console.Write(setNumber[i]);
                }
            }
        }
    }
}