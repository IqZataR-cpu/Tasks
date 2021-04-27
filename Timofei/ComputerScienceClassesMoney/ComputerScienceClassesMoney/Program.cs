using System;

namespace ComputerScienceClassesMoney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OutputActions();
        }

        private static void OutputActions()
        {
            while (true)
            {
                Console.Write("\nВведите первое число:");
                float numberLeft = float.Parse(Console.ReadLine());

                Console.Write("Введите второе число:");
                float numberRight = float.Parse(Console.ReadLine());

                Money left = new Money(numberLeft);
                Money right = new Money(numberRight);

                Console.WriteLine("\n1. Сложение");
                Console.WriteLine("2. Вычитание");
                Console.WriteLine("3. Деление");
                Console.WriteLine("4. Умножение");
                Console.WriteLine("5. Сравнение");

                int choise = int.Parse(Console.ReadLine());

                ProcessChoice(choise, left, right);
            }
        }

        private static void ProcessChoice(int choice, Money left, Money right)
        {
            switch (choice)
            {
                case 1:
                    Console.Write($"Сложение сумм: {left.Rubles} + {right.Rubles}");

                    Money addition = left + right;

                    Console.Write($" = {addition.Rubles}");
                    break;
                case 2:
                    Console.Write($"Разность сумм: {left.Rubles} - {right.Rubles}");

                    Money substraction = left - right;

                    Console.Write($" = {substraction.Rubles}");
                    break;
                case 3:
                    Console.Write($"Деление сумм: {left.Rubles} / {right.Rubles}");

                    Money division = left / right;

                    Console.Write($" = {division.Rubles}");
                    break;
                case 4:
                    Console.Write($"Умножение сумм: {left.Rubles} * {right.Rubles}");

                    Money multiplication = left * right;

                    Console.Write($" = {multiplication.Rubles}");
                    break;
                case 5:
                    // use method Money.Comparsion or bool comparsion = left | right;
                    // method return value true or false;
                    bool comparsion = Money.Comparsion(left, right);

                    if (!comparsion)
                    {
                        Console.WriteLine($"\n Число {left.Rubles} больше чем {right.Rubles}");
                    }
                    else
                    {
                        Console.WriteLine($"\n Число {left.Rubles} меньше чем {right.Rubles}");
                    }
                    break;
                default:
                    Console.Clear();

                    Console.WriteLine("Нет такого варианта.");
                    Console.WriteLine("Попробуй ещё раз.");

                    OutputActions();
                    break;
            }
        }
    }
}

public class Money
{
    private float _rubles;
    
    public float Rubles => _rubles;
    
    public Money(float rubles)
    {
        _rubles = rubles;
    }

    public static Money operator +(Money left, Money right)
    {
        left._rubles += right._rubles;
        
        return left;
    }   
    
    public static Money operator -(Money left, Money right)
    {
        left._rubles -= right._rubles;
        
        return left;
    } 
    
    public static Money operator /(Money left, Money right)
    {
        left._rubles /= right._rubles;
            
        return left;
    }
    
    public static Money operator *(Money left, Money right)
    {
        left._rubles *= right._rubles;
            
        return left;
    } 
    
    // you crazy?? why you override logic operator return value?? 
    // logic operator always need to return true or false. YOUR CASE RETURN MONEY! FUCK MOY MOZG!!!
    // and why you use "|" this symbol, we usually use this "||". 
    
    //Возможность перегрузки оператора
    //Определяемый пользователем тип может перегружать операторы !, &, | и ^.
    //При перегрузке бинарного оператора соответствующий оператор составного присваивания также неявно перегружается.
    //Определяемый пользователем тип не может перегружать оператор составного присваивания явным образом.
    //  Определяемый пользователем тип не может перегружать условные логические операторы && и ||.
    // При этом, если определяемый пользователем тип каким-либо образом перегружает операторы true и false и операторы
    // & и |, операция && или || может быть применена для операндов этого типа.
    // Дополнительные сведения см. в разделе Пользовательские условные логические операторы в Спецификации языка C#.
    public static bool Comparsion(Money left, Money right)
    {
        if (left._rubles < right._rubles)
        {
            return true;
        }
       
        return false;
    } 
    
    public static bool operator |(Money left, Money right)
    {
        if (left._rubles < right._rubles)
        {
            return true;
        }
       
        return false;
    }
}
