using System;

namespace arrayHard
{

    class Program
    {
        private static string[] hundreds    = new string[] { "Сто", "Двести", "Триста", "Четыреста", "Пятьсот", 
                                                             "Шестьсот", "Семьсот", "Восемьсот", "Девятьсот" };

        private static string[] decades     = new string[] { "Десять", "Двадцать", "Тридцать", "Сорок", "Пятьдесят", 
                                                             "Шестьдесят", "Семьдесят", "Восемьдесят", "Девяносто" };

        private static string[] numberUnits = new string[] { "Один", "Два", "Три", "Четыре", "Пять", "Шесть", "Семь", "Восемь", "Девять" };
        private static string[] secondDecade = new string[] { "Одиннадцать", "Двенадцать", "Тринадцать", 
                                                             "Четырнадцать", "Пятнадцать", "Шестнадцать", 
                                                             "Семнадцать", "Восемнадцать", "Девятнадцать" };

        static void Main(string[] args)
        {
            const int numberSize = 3;
            int[] mainArray = new int[numberSize];
            int translatableValue;
            Console.WriteLine("Введите трёхзначное число");
            int value = int.Parse(Console.ReadLine());

            for (int i = 2; i > -1; i--) 
            {
                mainArray[i] = value % 10;
                value /= 10;
            }

            for (int i = 0; i < 3; i++)
            {
                translatableValue = mainArray[i];

                switch (i)
                {
                    case 0:
                        OutputHundreds(translatableValue);    
                        break;
                    case 1:
                        if (translatableValue == 1)
                        {
                            translatableValue = mainArray[2];
                            OutputSecondDecade(translatableValue);
                            break;
                        }
                        OutputDecades(translatableValue);

                        translatableValue = mainArray[2];
                        OutputNumberUnits(translatableValue);
                        break;
                    default:
                        break;
                }
            }
        }
        
        static void OutputHundreds(int value)
        {
            Console.Write($"{hundreds[value - 1]} ");
        }
        
        static void OutputDecades(int value)
        {
            Console.Write($"{decades[value - 1]} ");
        }
        
        static void OutputNumberUnits(int value)
        {
            Console.Write($"{numberUnits[value - 1]} ");
        }

        static void OutputSecondDecade(int value)
        {
            Console.Write($"{secondDecade[value - 1]} ");
        }
    }
}
