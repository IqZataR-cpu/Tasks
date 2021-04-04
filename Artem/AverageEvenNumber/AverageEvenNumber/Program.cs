using System;

namespace AverageEvenNumber
{
    class Program
    {
        // MSDN c# говорит нам о том, что мы должны везде указывать область видимости
        // то есть private, public, protected по ситуации. Привыкаем!
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов массива: ");
            int countElements = int.Parse(Console.ReadLine());

            int[] numbers = CreateArray(countElements);
            Print(numbers);

            // нет смысла хранить результат в переменной, можно его сразу вывести на экран
            double average = AverageEven(numbers);
            Console.WriteLine("Ср. арифмитическое всех четных чисел стоящих " +
                $"на нечетных местах равно {average}");
        }

        static int[] CreateArray(int countElements)
        {
            Random random = new Random();
            int[] numbers = new int[countElements];

            // пробел!!!
            for(int i = 0; i <= countElements - 1; i++)
            {
                numbers[i] = random.Next(20);
            }

            return numbers;
        }

        static double AverageEven(int[] numbers)
        {
            double average = 0;
            // wtf is "new int()"??? Why not "= 0"?
            // Опять же указываем сначала объект, а потом его подчиненного,
            // то есть numbersCount более лаконичное название. 
            int countNumbers = new int();
                            // пробел!!!
            for (int i = 0; i<= numbers.Length - 1; i += 2)
            {
                if (isEvenNumber(numbers[i]))
                {
                    average += numbers[i];
                    countNumbers++;
                }
            }

            return average / countNumbers;
        }

        // В английской языке предпочтительнее было бы сначала указать объект,
        // а потом его качество, то есть isNumberEven
        static bool isEvenNumber(int number)
        {
            // такие методы сокращаются до однострочных return number % 2 == 0;
            if (number % 2 == 0)
            {
                return true;
            }

            return false;
        }

        static void Print(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }

            Console.WriteLine();
        }
    }
}
