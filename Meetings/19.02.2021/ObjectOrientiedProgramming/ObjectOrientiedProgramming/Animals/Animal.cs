using System;

namespace ObjectOrientiedProgramming.Animals
{
    public class Animal
    {
        protected int _weight;
        protected int _health = 100;
        protected int _stamina = 100;
        protected string _name;

        public Animal(int weight, string name)
        {
            _weight = weight;
            _name = name;
        }

        public void PrintHealth()
        {
            Console.WriteLine($"Текущее здоровье: {_health.ToString()}");
        }
        
        public void PrintStamina()
        {
            Console.WriteLine($"Текущая выносливость: {_stamina.ToString()}");
        }
    }
}