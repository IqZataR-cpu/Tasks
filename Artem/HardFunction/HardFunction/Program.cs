using System;

namespace HardFunction
{
    // В целом все прекрасно, уже приятно смотреть,
    // но не смог реализовать правильный алгоритм,
    // поэтому придется доработать саму функцию поиска
    class Program
    {
        static void Main(string[] args)
        {
            // Для большей читаемости дели такие объявления на 2 строки, пример ниже
            int[] numbers = new int[16] {
                2, 4, 8, 16, 32, 64, 128, 256, 512, 1024,
                2048, 4096, 8192, 16384, 32768, 65536 
            };
            int inputNumber;
            int numberOfElementArray;

            Console.WriteLine("Введите число");
            inputNumber = int.Parse(Console.ReadLine());

            numberOfElementArray = BinarySearching(numbers, inputNumber);

            if (numberOfElementArray == 0)
            {
                Console.WriteLine($"Число {inputNumber} не существует в массиве");
                return;
            }

            // Также длинные строковые выражения стараемся сделать с переносом на следующую строку, пример ниже
            Console.WriteLine($"Число {inputNumber} существует в массиве " +
                              $"и оно находится на {numberOfElementArray} месте");
        }

        
        // Не до конца понял принцип бинарного поиска,
        // ты делишь массив на 2 и потом отдельно по левой и правой части проходишься полностью
        // Это не бинарный поиск.
        // Бинарный поиск подразумевает под собой постоянное деление на 2 части массива
        // и сравнение среднего элемента с тем который нужно найти
        // То есть ты снова должен найти середину массива в левой части,
        // если число меньше середины и в правой, если больше и так до тех пор пока не найдешь число.
        // Поэтому функция так хорошо работает с рекурсией, но не обязательно ее делать именно такой(рекурсивной).
        static int BinarySearching(int[] numbers, int number)
        {
            // zero не корректное название, тут нужно было назвать так NUMBER_NOT_FOUND
            // для констант применяет ALL_CAPS стиль написания.
            const int zero = 0;
            int lengthArray = numbers.Length - 1;
            int middleArray = lengthArray / 2;

            // Это круто, но у программистов не принято так писать,
            // такое объявление заменяется на функции с аналогичным именем.
            // На будущее, можно было сделать класс, который принимает на вход массив
            // И создать метод поиска в массиве,
            // тогда пришлось бы в методе указывать на один параметр меньше
            // Также создать дополнительно приватные методы,
            // названия которых соответствуют твоим булевым выражениям
            // это гораздо более читабельно и не вызовет вопросов о твоем образовании
            // Я знаю, что я этому научил, но я этому научил для того,
            // чтобы в последствии это можно было перенести на функции, как в примере выше.
            // Также не совсем корректное название,
            // можно описать цель сравнения двумя словами isFind или isExist,
            // поскольку мы работаем с контекстом number, видим это по параметру
            // и метод называется Searching, то будет понятно что именно isExist/isFind
            bool isNumberEqualsNumberOfArray = number == numbers[middleArray];
            if (isNumberEqualsNumberOfArray)
            {
                return middleArray;
            }

            // Здесь все логично, но заменяемо методом,
            // но только с условием что сделано будет через класс
            bool isNumberMoreThanMiddle = number > numbers[middleArray];
            if (isNumberMoreThanMiddle)
            {
                for (int i = middleArray + 1; i <= numbers.Length; i++)
                {
                    isNumberEqualsNumberOfArray = number == numbers[i];

                    if (isNumberEqualsNumberOfArray)
                    {
                        return i + 1;
                    }
                }
            }
            else
            {
                for (int i = middleArray - 1; i >= 0; i--)
                {
                    isNumberEqualsNumberOfArray = number == numbers[i];

                    if (isNumberEqualsNumberOfArray)
                    {
                        return i + 1;
                    }
                }
            }

            return zero;
        }
    }
}