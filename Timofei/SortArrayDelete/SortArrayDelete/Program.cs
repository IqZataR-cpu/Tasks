﻿using System;

namespace SortArrayDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            // Отсортировать массив методом Пузырька.
            
            int[] arrayInput = new int[10];
            Random rnd = new Random();
            // не корректное название переменной.
            // Нет смысла указывать в названии что это число, лучше писать конкретное предназначение переменной.
            // Ну и само название не соответствует использованию переменной. Логичнее было бы temp.
            int minNumber;
            
            for (int i = 0; i < arrayInput.Length; i++)
            {
                arrayInput[i] = rnd.Next(100);
            }
            
            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i + 1; j < arrayInput.Length; j++)
                {
                    if (arrayInput[j] < arrayInput[i])
                    {
                        minNumber = arrayInput[i];
                        arrayInput[i] = arrayInput[j];
                        arrayInput[j] = minNumber;
                    }
                }

                Console.Write($"{arrayInput[i]} ");
            }
        }
    }
}
