using System;

namespace ValidationUserInput
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // не обязательно всегда писать чей это инпут.
            // здесь по контексту и так понятно.
            int userInput;

            Console.WriteLine("Введите любое число: ");
            userInput = int.Parse(Console.ReadLine());

            // isNumberEqualsTen более красивое название, но
            // не стоит такие простейшие условия выносить в методы
            // выносим только не понятные условия,
            // здесь для понятности, можно было сделать константу или просто забить. 
            if (isNumberOfTen(userInput))
            {
                Console.WriteLine("Верно");
            }
            else
            {
                Console.WriteLine("Неверно");
            }
        }

        private static bool isNumberOfTen(int number)
        {
            return number == 10;
        }
    }
}
