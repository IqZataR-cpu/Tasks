using System;

namespace ComputerScienceCyclesDefineMaxNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число"); 
            int input = int.Parse(Console.ReadLine());
            
            // Здесь не нужен второй параметр.
            // Даже если бы он был нужен, то нет смысла вызывать класс Convert,
            // У многих c# типов по умолчанию есть метод ToString,
            // То есть можно было просто сделать input.ToString().Length()
            input = IsMaxNumber(input, Convert.ToString(input).Length);
           
            Console.WriteLine($"Максимальное число: {input}");
        }

        // Зачем здесь count? почему ты не сделал while input > 0?
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
