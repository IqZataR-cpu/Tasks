using System;

namespace ObjectOrientiedProgramming.Animals
{
    public class Dog : Animal, IAnimal
    {
        public Dog(int weight, string name) : base(weight, name)
        {
            
        }

        public void Greetings()
        {
            Console.WriteLine("Hi i am a dog");
        }

        public void Eat()
        {
            _stamina += _stamina / 5;
        }

        public void Run()
        {
            _stamina -= _stamina / 2;
        }

        public void Idle()
        {
            _stamina += _stamina / 5;
        }
    }
}