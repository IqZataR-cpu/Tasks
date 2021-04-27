using System;

namespace ComputerScienceClassesMoney
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action.OutputActions();
        }
    }
}

// Название класса Action настолько же бессмысленное как и Program,
// поэтому в данном случае можно было все оставить в рамках класса Program.
public class Action
{
    public static void OutputActions()
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

    private static void ProcessChoice(int choice, Money moneyOne, Money moneyTwo)
    {
        switch (choice)
        {
            case 1:
                Console.Write($"Сложение сумм: {moneyOne.Rubles} + {moneyTwo.Rubles}");
                
                Money addition = moneyOne + moneyTwo;
                
                Console.Write($" = {addition.Rubles}");
                break;
            case 2:
                Console.Write($"Разность сумм: {moneyOne.Rubles} - {moneyTwo.Rubles}");
                
                Money substraction = moneyOne - moneyTwo;
                
                Console.Write($" = {substraction.Rubles}");
                break;
            case 3:
                Console.Write($"Деление сумм: {moneyOne.Rubles} / {moneyTwo.Rubles}");
                
                Money division = moneyOne / moneyTwo;
                
                Console.Write($" = {division.Rubles}");
                break;
            case 4:
                Console.Write($"Умножение сумм: {moneyOne.Rubles} * {moneyTwo.Rubles}");
                
                Money multiplication = moneyOne * moneyTwo;
                
                Console.Write($" = {multiplication.Rubles}");
                break;
            case 5:
                Console.Write($"Сравнение сумм: {moneyOne.Rubles} | {moneyTwo.Rubles}");
               
                Money comparsion = moneyOne | moneyTwo;
                
                Console.WriteLine($"\n Число {comparsion.Rubles} больше.");
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
    public static Money operator |(Money left, Money right)
    {
        return left._rubles > right._rubles ? left : right;
    }
}
