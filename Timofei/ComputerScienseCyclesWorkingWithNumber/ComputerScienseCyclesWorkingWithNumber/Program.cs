using System;

namespace ComputerScienseCyclesWorkingWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, подсчитывающую количество четных и нечетных цифр в числе.
            
            string dataInput = Console.ReadLine();
            int counterEvenNumbers = 0; // 
            int counterOddNumbers = 0; // 

            for (int i = 0; i < dataInput.Length; i++)
            {
                if (Convert.ToChar(dataInput[i]) % 2 ==0)
                {
                    counterEvenNumbers++;
                }
                else
                {
                    counterOddNumbers++;
                }
            }
            
            Console.WriteLine($"Кол-во четных чисел: {counterEvenNumbers}");
            Console.WriteLine($"Кол-во нечетных чисел: {counterOddNumbers}");
        }
    }
}