using System;

namespace InvertNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input;
            string invertNumber;

            Console.WriteLine("Введите число: ");
            input = int.Parse(Console.ReadLine());

            Console.WriteLine($"Инвертированное число {invertNumber = Inversion(input)}");
        }

        private static string Inversion(int number)
        {
            Char[] digits = number.ToString().ToCharArray();

            Array.Reverse(digits);

            return new string(digits);

            // Заметка нерабочая, так как Reverse() принимает аргументы, а их нет, поэтому это не сработает.
            // Look at this https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.reverse?view=net-5.0#-------
            // Для заметки: return new string(number.ToString().ToCharArray().Reverse()) можно было и так, чтобы не хранить лишний раз в памяти значения.)))
        }
    }
}
