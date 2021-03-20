using System;

namespace ComputerScienseCyclesWorkingWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, подсчитывающую количество четных и нечетных цифр в числе.
            
            // Не обработал пользовательский ввод сообщением Console.Write("Введите число")
            string dataInput = Console.ReadLine();
            int counterEvenNumbers = 0;  
            int counterOddNumbers = 0;  

            for (int i = 0; i < dataInput.Length; i++)
            {
                // Забыл пробел после ==
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