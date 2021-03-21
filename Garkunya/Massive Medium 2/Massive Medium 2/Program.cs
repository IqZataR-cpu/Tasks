using System;

namespace Massive_Medium_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            
            Console.Write("Введите количество элементов массива: ");
            
            int n = int.Parse(Console.ReadLine()); //вводим количество элементов
            int[] myArray = new int[n]; //создаем массив с n размером
            int countNumber = 0;  //переменная, которая будет хранить кол-во элементов
            float sumNumber = 0; // переменная, которая будет хранить сумму элементов

            for (int i = 0; i < myArray.Length; i++) //заполняем массив случайными числами от 0 до 100
            {
                myArray[i] = rnd.Next(0, 100);
                Console.Write(myArray[i]+" ");
            }
            
            Console.WriteLine(); 

            for (int i = 0; i < myArray.Length; i++) //проверяем число на условие
            {
                if (myArray[i]%2==0)
                {
                    if (i%2 != 0)
                    {
                        sumNumber += myArray[i];
                        countNumber++;
                    }
                }
            }
            
            sumNumber = sumNumber / countNumber;
            
            Console.WriteLine($"Среднее арифметическое {countNumber} чисел = {sumNumber}"); //выводим результат
        }
    }
}