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
            string invertNumber = number.ToString();
            Char[] digits = invertNumber.ToCharArray();

            Array.Reverse(digits);

            return invertNumber = new string(digits);
            
            // Для заметки: return new string(number.ToString().ToCharArray().Reverse()) можно было и так, чтобы не хранить лишний раз в памяти значения.)))
        }
    }
}
