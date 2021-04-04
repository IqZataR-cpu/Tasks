using System;

namespace Testing
{
    // Кто сколько успеет сделать.
    // Задания
    // 1. Добавить методы вычитания, деления(предусмотреть деление на 0) для Калькулятора и к ним тесты.
    //
    // Для простоты делать все публичным и использовать int.
    // 2. Создать класс Unit, который имеет MaxHealth = 100 и CurrentHealth(из конструктора) и метод Heal
    // Метод Heal - всегда исцеляет юнита на 20(или ваше число), то есть CurrentHealth += 20
    // В методе Heal организовать проверку что CurrentHealth не должно превышать MaxHealth
    // Создать тесты, которые проверяют функционал метода Health.
    //
    // Для простоты делать все публичным.
    // 3. Добавить свойство AttackDamage(из конструктора), метод Attack(Unit target) и ApplyDamage(int damage) для Unit
    // Метод Attack - вызывает метод ApplyDamage у target, то есть target.ApplyDamage(AttackDamage)
    // Метод ApplyDamage - отнимает входящий урон из здоровья, то есть CurrentHealth -= damage
    // В методе ApplyDamage(int damage) сделать проверку, что урон не превышает текущее здоровье и,
    // если превышает, то обнулять здоровье.
    // Создать тесты, которые проверяют функционал методов Attack и ApplyDamage 
    //
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}