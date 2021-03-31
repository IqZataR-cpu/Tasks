using System;

namespace ComputerScienceCyclesDefineMaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число"); 
            int input = int.Parse(Console.ReadLine());
            
            input = IsMaxNumber(input);
           
            Console.WriteLine($"Максимальное число: {input}");
        }
        
        // Префиксы is, can, has... применимы только к булевым типам.
        // В данном случае GetMaxNumber более звучное и применимое слово.
        public static int IsMaxNumber(int input)
        {
            int maxNumber = 0;

            while (input > 0)
            {
                if (input % 10 > maxNumber)
                {
                    maxNumber = input % 10;
                }
                
                input = input / 10;
            }

            return maxNumber;
        }
    }
}
