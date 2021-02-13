using System;

// namespace всегда с большой буквы, пишем используя camelCase, не snake_case
namespace array_hard_
{

    // В программе фигурируют трехзначные числа,
    // поэтому для большей ясности можно завести константу
    // const int NumberSize = 3;
    // В программировании такая ошибка называется магические числа
    // Когда ты видишь число, не знаешь его предназначения и пытаешься догадаться почему именно 3.
    class Program
    {
        static void Main(string[] args)
        {
            int[] mainArray = new int[3];
            int translatableValue;
            // Мини пояснение не помешало бы, а то не понятно вводить или ждать
            int value = int.Parse(Console.ReadLine());

            for (int i = 2; i > -1; i--) 
            {
                mainArray[i] = value % 10;
                
                // сокращаем выражение, если это возможно 
                // value /= 10;
                value = value / 10;
            }

            for (int i = 0; i < 3; i++)
            {
                translatableValue = mainArray[i];

                switch (i)
                {
                    case 0:
                        outputHundreds(translatableValue);    
                        break;
                    case 1:
                        if (translatableValue == 1)
                        {
                            translatableValue = mainArray[2];
                            outputSecondDecade(translatableValue);
                            break;
                        }
                        outputDecades(translatableValue);

                        translatableValue = mainArray[2];
                        outputUnits(translatableValue);
                        break;
                    default:
                        break;
                }
            }
        }
        
        // Enter между методами и название с большой буквы,
        // аргументы функции с маленькой
        static void outputHundreds(int Value)
        {
            // Легко меняется на массив строк
            // Наверху объявляется константа примерно так
            // private static const string[] Hundreds = new string[] {"Сто", "Двести" ....};
            // И код превращается в следующий:
            // Console.Write(Hundreds[value + 1])
            // + 1 потому что индекс с 0 в массиве.
            // Можно еще добавить проверку на наличие и выход за пределы массива
            
            switch (Value)
            {
                case 1:
                    Console.Write("Сто ");
                    break;
                case 2:
                    Console.Write("Двести ");
                    break;
                case 3:
                    Console.Write("Триста ");
                    break;
                case 4:
                    Console.Write("Четыреста ");
                    break;
                case 5:
                    Console.Write("Пятьсот ");
                    break;
                case 6:
                    Console.Write("Шестьсот ");
                    break;
                case 7:
                    Console.Write("Семьсот ");
                    break;
                case 8:
                    Console.Write("Восемьсот ");
                    break;
                case 9:
                    Console.Write("Девятьсот ");
                    break;
                default:
                    break;
            }
        }
        
        // Смотри пример выше
        static void outputDecades(int Value)
        {
            switch (Value)
            {
                case 1:

                    break;
                case 2:
                    Console.Write("Двадцать ");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write("Сорок ");
                    break;
                case 5:
                    Console.Write("Пятьдесят ");
                    break;
                case 6:
                    Console.Write("Шестьдесят ");
                    break;
                case 7:
                    Console.Write("Семьдесят ");
                    break;
                case 8:
                    Console.Write("Восемьдесят ");
                    break;
                case 9:
                    Console.Write("Девяносто ");
                    break;
                default:
                    break;
            }
        }
        
        // Смотри пример выше
        // Название не корректное, unit - единица какого то объекта,
        // нужно было указать точнее outputNumberUnits,
        // либо подобрать другое слово
        // Это правило отменяется, если метод был бы указан в классе Number
        static void outputUnits(int Value)
        {
            switch (Value)
            {
                case 1:
                    Console.Write("Один");
                    break;
                case 2:
                    Console.Write("Два");
                    break;
                case 3:
                    Console.Write("Три");
                    break;
                case 4:
                    Console.Write("Четыре");
                    break;
                case 5:
                    Console.Write("Пять");
                    break;
                case 6:
                    Console.Write("Шесть");
                    break;
                case 7:
                    Console.Write("Семь");
                    break;
                case 8:
                    Console.Write("Восемь");
                    break;
                case 9:
                    Console.Write("Девять");
                    break;
                default:
                    break;
            }
        }

        // Смотри пример выше
        static void outputSecondDecade(int Value)
        {
            switch (Value)
            {
                case 1:
                    Console.Write("Одиннадцать");
                    break;
                case 2:
                    Console.Write("Двенадцать");
                    break;
                case 3:
                    Console.Write("Тринадцать");
                    break;
                case 4:
                    Console.Write("Четырнадцать");
                    break;
                case 5:
                    Console.Write("Пятнадцать");
                    break;
                case 6:
                    Console.Write("Шестнадцать");
                    break;
                case 7:
                    Console.Write("Семнадцать");
                    break;
                case 8:
                    Console.Write("Восемнадцать");
                    break;
                case 9:
                    Console.Write("Девятнадцать");
                    break;
                default:
                    break;
            }
        }
    }
}
