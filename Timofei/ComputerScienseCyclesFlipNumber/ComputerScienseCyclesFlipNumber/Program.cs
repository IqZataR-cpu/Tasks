using System;

namespace ComputerScienseCyclesFlipNumber
{
    class Program
    {
        // Вводится число, преобразовать его в другое число, цифры которого будут следовать
        // в обратном порядке по сравнению с введенным числом.
        // Пример: Входные данные 123456. Ожидаемое значение 654321.
        
        static void Main(string[] args)
        {
            int dataInput = int.Parse(Console.ReadLine());
           
            FlipNumberMethodTwo(dataInput);
        }
    
        static void FlipNumberMethodTwo(int dataInput)
        { 
            // Проблема с табуляцией!!!
            while (dataInput > 0)
            { 
                Console.Write($"{dataInput % 10}");
               
                dataInput /= 10;   
            }
        }
    }
}
