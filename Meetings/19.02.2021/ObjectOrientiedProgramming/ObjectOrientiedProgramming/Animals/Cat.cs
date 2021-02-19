using System;

namespace ObjectOrientiedProgramming.Animals
{
    public class Cat : Animal, IAnimal
    {
        public Cat(int weight, string name) : base(weight, name)
        {
            
        }

        public void Greetings()
        {
            Console.WriteLine("Hi i am a cat");
        }

        public void Eat()
        {
            _stamina += _stamina / 2;
        }

        public void Run()
        {
            _stamina -= _stamina / 5;
        }

        public void Idle()
        {
            _stamina += _stamina / 5;
        }
    }
}