using System;

namespace User_Input_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int chekedValue = (User_Input_Validation.Input());
            User_Input_Validation.Check(chekedValue);
        }
    }

    class User_Input_Validation
    {
        //Решил усложнить себе задачу и сделал задачу через классы
        static public int Input()
        {
            Console.Write("Введите число: ");
            int inputValue = int.Parse(Console.ReadLine());

            return inputValue;
        }

        static public void Check(int chekedValue)
        {
            if (chekedValue == 10)
            {
                ValidationSuccesful();
            }
            else
            {
                ValidationFailed();
            }
        }

        static private void ValidationSuccesful()
        {
            Console.WriteLine("Валидация пройдена");
        }

        static private void ValidationFailed()
        {
            Console.WriteLine("Валидация провалена");
        }
    }
}
