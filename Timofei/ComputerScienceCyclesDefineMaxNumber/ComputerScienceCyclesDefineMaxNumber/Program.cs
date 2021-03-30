using System;

namespace ComputerScienceCyclesDefineMaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число"); 
            int input = int.Parse(Console.ReadLine());
            
            input = IsMaxNumber(input, Convert.ToString(input).Length);
           
            Console.WriteLine($"Максимальное число: {input}");
        }

        public static int IsMaxNumber(int input, int count)
        {
            int maxNumber = 0;
            
            for (int i = 0; i < count; i++)
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