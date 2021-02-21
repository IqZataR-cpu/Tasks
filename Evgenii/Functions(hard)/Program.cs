using System;

namespace Functions_hard_
{
    class Program
    {
        private static int[] array = new int[] { 1, 3, 6, 8, 11, 25, 57, 65, 100 };

        static void Main(string[] args)
        {
            int enteredValue;
            int? index;

            Console.WriteLine("Введите значение массива");
            enteredValue = int.Parse(Console.ReadLine());

            index = searchIndex(enteredValue);
            if (index == null)
            {
                Console.WriteLine("Значения не существует");
            }
            else
            {
                Console.WriteLine(index + 1);
            }
        }

        private static int? searchIndex(int? value)
        {
            int middleOfArray = array.Length / 2;
            int counter = 1;
            int? index;
            index = null;

            while ((middleOfArray >= 0 && counter < array.Length) &&
                   (middleOfArray <= array.Length && counter < array.Length))
            {
                counter = counter * 2;

                if (array[middleOfArray] == value)
                {
                    index = middleOfArray;
                    break;
                }

                else if (array[middleOfArray] > value)
                {
                    middleOfArray = middleOfArray - array.Length / counter;
                    continue;
                }

                    middleOfArray = middleOfArray + array.Length / counter;
            }

            return index;
        }
    }
}
