using System;

namespace Quarter_of_hour
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = DefinitionQuarterOfHour.InputNumber();

            if (inputNumber > 0 && inputNumber < 59)
            {
                string transformNumber = DefinitionQuarterOfHour.TransformNumber(inputNumber);
                DefinitionQuarterOfHour.OutputQuarter(transformNumber);
            }
            else
            {
                Console.WriteLine("Введено неправильное число");
            }
        }
    }

    class DefinitionQuarterOfHour
    {
        static public int InputNumber()
        {
            Console.WriteLine("Введите число от 0 до 59");
            int inputNumber = int.Parse(Console.ReadLine());

            return inputNumber;
        }

        static public string TransformNumber(int inputNumber)
        {
            string transformNumber;
            if (inputNumber >= 1 && inputNumber <= 15)
            {
                transformNumber = "в первой";
            }
            else if (inputNumber >= 16 && inputNumber <= 30)
            {
                transformNumber = "во второй";
            }
            else if (inputNumber >= 31 && inputNumber <= 45)
            {
                transformNumber = "в третьей";
            }
            else 
            {
                transformNumber = "в четвертой";
            }

            return transformNumber;
        }

        static public void OutputQuarter(string transformNumber)
        {
            Console.WriteLine($"Число находится {transformNumber} четверти");
        }
    }
}