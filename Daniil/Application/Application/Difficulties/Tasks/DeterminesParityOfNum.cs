using System;

namespace Application
{
    public class DeterminesParityOfNum : Task
    {
        private const string TASK = "Из двух случайных чисел, одно из которых четное," +
                                    " а другое нечетное, определить и вывести на экран нечетное число.";
        
        public override void Solution()
        {
            Console.WriteLine(TASK);
            Console.Write("Введите число:"); 
            int firstNum = int.Parse(Console.ReadLine());
            
            if (firstNum % 2 != 0)
            {
                Console.WriteLine($"число {firstNum.ToString()} - нечетное");
            }
            else 
            {
                Console.WriteLine($"число {firstNum.ToString()} - четное");
            }
        }
    }
}